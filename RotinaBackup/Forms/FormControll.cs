using RotinaBackupService.Func.Conection;
using RotinaBackupService.Forms;

namespace RotinaBackupService.Forms
{
    public class FormControll
    {
        private frmConexaoForm _conexaoFrm;
        private frmHomeForm _homeFrm;
        private frmSettingsBkpForm _settingsFrm;

        public void OpenHomeForm()
        {
            _homeFrm = new frmHomeForm();
            System.Windows.Forms.Application.Run(_homeFrm);
        }

        public void OpenConexaoForm(int operacao)
        {
            _conexaoFrm = new frmConexaoForm(operacao);
            _conexaoFrm.ShowDialog();
        }
        
        public void OpenSettingsForm()
        {
            _settingsFrm = new frmSettingsBkpForm();
            _settingsFrm.ShowDialog();
        }
    }
}
