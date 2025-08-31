public interface IFinanceRecordRepository
{
    public void AddFinanceRecord(FinanceRecord financeRecord);
    List<FinanceRecord> GetFinanceRecords(int userId);
    FinanceRecord GetFinanceRecord(int id);
}