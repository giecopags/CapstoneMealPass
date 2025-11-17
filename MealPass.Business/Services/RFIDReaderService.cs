using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCSC;
using Sydesoft.NfcDevice;

namespace MealPass.Business.Services
{
    public class RFIDReaderService
    {
        private ISCardContext cardContext;
        private string[] readerNames;
        private static ACR122U cardReader = new ACR122U();

        public event Action<string> OnCardScanned;
        public event Action OnCardRemoved;
        public event Action<string> OnStatusChanged;

        public void Initialize()
        {
            try
            {
                cardContext = ContextFactory.Instance.Establish(SCardScope.System);
                readerNames = cardContext.GetReaders();

                if (readerNames.Length == 0)
                {
                    OnStatusChanged?.Invoke("No card reader detected!");
                    return;
                }

                OnStatusChanged?.Invoke("Reader found: " + readerNames[0]);
                cardReader.Init(false, 50, 4, 4, 100);

                cardReader.CardInserted += CardInserted;
                cardReader.CardRemoved += CardRemoved;

                OnStatusChanged?.Invoke("Waiting...");
            }
            catch (Exception ex)
            {
                OnStatusChanged?.Invoke("Failed to initialize reader: " + ex.Message);
            }
        }

        private void CardInserted(ICardReader reader)
        {
            try
            {
                string rfid = BitConverter.ToString(cardReader.GetUID(reader)).Replace("-", "");
                OnCardScanned?.Invoke(rfid);
            }
            catch (Exception ex)
            {
                OnStatusChanged?.Invoke("Error reading RFID: " + ex.Message);
            }
        }

        private void CardRemoved()
        {
            OnCardRemoved?.Invoke();
            OnStatusChanged?.Invoke("Card removed.");
        }
    }

}

