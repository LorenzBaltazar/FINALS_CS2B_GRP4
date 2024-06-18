using System.Windows.Forms;

namespace FINALS_CS2B_GRP4
{
    // This interface is used so that when a form is created,
    // it can refresh the datagrid of the form that called it
    public interface IRefreshable
    {
        void refreshDatagrid();
    }
}
