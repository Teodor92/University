namespace WinFormControls
{
    using System.Windows.Forms;

    using WinFormControls.Data;
    using WinFormControls.Data.Contracts.Base;

    public partial class BaseForm : Form
    {
        protected BaseForm()
        {
            this.Data = DataManager.Instance;
        }

        protected IDataManager Data { private set; get; }
    }
}
