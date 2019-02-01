using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication
{
    public class SettlementBatchResponse
    {
        public SettlementBatchResponse(int lenth)
        {
            Batches = new Batch[lenth];
        }
        public Batch[] Batches { get; set; }
        public ChargebackDetail[] Chargebacks { get; set; }
        public string DbaName { get; set; }
        public string MID { get; set; }
        public string RespMsg { get; set; }
        public string Status { get; set; }

    }
    public class Batch
    {
        public DateTime BatchDate { get; set; }
        public int BatchId { get; set; }
        public int IbxBatchId { get; set; }
        public double HeldAmount { get; set; }
        public double ReturnAmount { get; set; }
        public double SaleAmount { get; set; }
        public int TransactionCount { get; set; }
    }
    public class Batch1
    {
        public DateTime BatchDate { get; set; }
        public int BatchId { get; set; }
        public int IbxBatchId { get; set; }
        public double HeldAmount { get; set; }
        public double ReturnAmount { get; set; }
        public double SaleAmount { get; set; }
        public int TransactionCount { get; set; }
    }
    public partial class ChargebackDetail : Chargeback
    {
    }
    public class Chargeback
    {

        public string AuthorizationCode { get; set; }
        public string CardType { get; set; }
        public double ChargebackAmount { get; set; }
        public int ChargebackId { get; set; }
        public string Description { get; set; }
        public double FeeAmount { get; set; }
        public string HumanReadableCardNumber { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string Status { get; set; }
        public double TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionId { get; set; }
    }

    public class SettleDetailResponse
    {
        public BatchDetails[] BatchDetails { get; set; }
        public ChargebackDetail[] ChargebackDetails { get; set; }
        public string RespMsg { get; set; }
        public string Status { get; set; }

    }

    public class BatchDetails
    {
        public DateTime AchDate { get; set; }
        public string AuthorizationCode { get; set; }
        public double AuthorizedAmount { get; set; }
        public DateTime BatchDate { get; set; }
        public int BatchId { get; set; }
        public string CardType { get; set; }
        public string HumanReadableCardNumber { get; set; }
        public string SettledBy { get; set; }
        public string Status { get; set; }
        public double TransactionAmount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionId { get; set; }
        public string TransactionType { get; set; }
    }
    public class SettlementBatchResponse1
    {
        public Batch1[] Batches { get; set; }
        public ChargebackDetail[] Chargebacks { get; set; }
        public string DbaName { get; set; }
        public string MID { get; set; }
        public string RespMsg { get; set; }
        public string Status { get; set; }
    }
    class ArrayToObjectList
    {

        static void Main(string[] args)
        {

            ChargebackDetail[] chr = new ChargebackDetail[1];
            chr[0] = new ChargebackDetail
            {
                AuthorizationCode = "699075",
                CardType = "Visa",
                ChargebackAmount = 65,
                ChargebackId = 63852,
                Description = "Duplicate Transaction",
                FeeAmount = 30,
                HumanReadableCardNumber = "473702xxxxxx3042",
                ReceivedDate = Convert.ToDateTime("6/1/2017"),
                Status = "Stand",
                TransactionAmount = 65,
                TransactionDate = Convert.ToDateTime("6/1/2017"),
                TransactionId = "376987340"
            };
            var objectArray = new object[] { 3, 5, 3.3, "test" };

            Batch1[] pp = new Batch1[4];
            pp[0] = new Batch1
            {
                BatchDate = Convert.ToDateTime("6/1/2017"),
                BatchId = 53404339,
                HeldAmount = 0,
                IbxBatchId = 0,
                ReturnAmount = 0,
                SaleAmount = 270,
                TransactionCount = 2

            };
            pp[1] = new Batch1
            {
                BatchDate = Convert.ToDateTime("6/1/2017"),
                BatchId = 53404339,
                HeldAmount = 0,
                IbxBatchId = 0,
                ReturnAmount = 0,
                SaleAmount = 270,
                TransactionCount = 2

            };
            pp[2] = new Batch1
            {
                BatchDate = Convert.ToDateTime("6/1/2017"),
                BatchId = 53404339,
                HeldAmount = 0,
                IbxBatchId = 0,
                ReturnAmount = 0,
                SaleAmount = 270,
                TransactionCount = 2

            };
            pp[3] = new Batch1
            {
                BatchDate = Convert.ToDateTime("6/1/2017"),
                BatchId = 53404339,
                HeldAmount = 0,
                IbxBatchId = 0,
                ReturnAmount = 0,
                SaleAmount = 270,
                TransactionCount = 2

            };
            SettlementBatchResponse1 obj = new SettlementBatchResponse1()
            {
                Batches = pp,
                Chargebacks = chr,
                DbaName = "SUNU HAIR SALON",
                RespMsg = "",
                MID = "403903132400039",
                Status = "OK"
            };


            SettlementBatchResponse _settlementBatchResponse = new SettlementBatchResponse(obj.Batches.Length);
            _settlementBatchResponse.Batches = obj.Batches.OfType<Batch>().ToArray();
            _settlementBatchResponse.Chargebacks = obj.Chargebacks.OfType<ChargebackDetail>().ToArray();
            _settlementBatchResponse.DbaName = obj.DbaName;
            _settlementBatchResponse.RespMsg = obj.RespMsg;
            _settlementBatchResponse.MID = obj.MID;
            _settlementBatchResponse.Status = obj.Status;
            var serializedoubleClass = JsonConvert.SerializeObject(obj);
            SettlementBatchResponse objCustomer = JsonConvert.DeserializeObject<SettlementBatchResponse>(serializedoubleClass);

            var intArray = objectArray.OfType<int>().ToArray();

        }
    }
}
