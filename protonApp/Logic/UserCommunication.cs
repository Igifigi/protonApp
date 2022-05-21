using System.Windows.Forms;

namespace protonApp.Logic
{
    class UserCommunication
    {
        #region Message boxes
        public void ShowErrorBox(string message)
        {
            MessageBox.Show(message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowInfoBox(string message)
        {
            MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ShowQuestionBox(string message)
        {
            if (MessageBox.Show(message, "Zapytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
