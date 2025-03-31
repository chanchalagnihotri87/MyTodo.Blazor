namespace MyTodo.Blazor.Client.Services
{
    public class TabHelper
    {
        private string _currentTab;

        public TabHelper(string currentTab)
        {
            _currentTab = currentTab;
        }

        public void SetCurrentTab(string tabName)
        {
            _currentTab = tabName;
        }

        public bool IsTabActive(string tabName)
        {
            return tabName == _currentTab;
        }

        public string GetTabClass(string tabName)
        {
            return IsTabActive(tabName) ? "active" : "";
        }
    }
}
