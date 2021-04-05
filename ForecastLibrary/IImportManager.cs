using Forecast;

namespace ForecastLibrary
{
    public interface IImportManager
    {
        int DateColumn { get; set; }
        IForecastingManager ForecastingManager { get; set; }
        string InventoryFile { get; set; }
        string[] InventoryFileContent { get; set; }
        int InventoryOnHandColumn { get; set; }
        int LeadTimeColumn { get; set; }
        string NonStandardDateFormat { get; set; }
        int ProductIdColumnInInventory { get; set; }
        int ProductIdColumnInSales { get; set; }
        int ProductTitleColumn { get; set; }
        string SalesFile { get; set; }
        string[] SalesFileContent { get; set; }
        char SplitBy { get; set; }
        bool StandardDate { get; set; }
        int UnitsSoldColumn { get; set; }
        int VariantTitleColumn { get; set; }

        bool ImportData(int productIdColumnInInventory = 0, int inventoryOnHandColumn = 0, int leadTimeColumn = 0, int productIdColumnInSales = 0, int dateColumn = 0, int unitsSoldColumn = 0, int productTitleColumn = 0);
    }
}