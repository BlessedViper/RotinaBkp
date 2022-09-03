using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaBackupService.Func
{
    public class Cripto
    {
        public string Pass { private get; set; }
        public string _criptoPass;
        private int _intPass;
        
        public Cripto(string pass)
        {
            Pass = pass;
        }
        public string SetCripto()
        {
            _intPass = Convert.ToInt32(Pass);
            _intPass += 94;
            _intPass *= 2;
            _intPass += 32;
            _criptoPass = Convert.ToString(_intPass);
            return _criptoPass;
        }

        public string GetPass()
        {
            _intPass = Convert.ToInt32(Pass);
            _intPass -= 32;
            _intPass /= 2;
            _intPass -= 94;
            var pass2 = Convert.ToString(_intPass);
            return pass2;
        }
    }
}
