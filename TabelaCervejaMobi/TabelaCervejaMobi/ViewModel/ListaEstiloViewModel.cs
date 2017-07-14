using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TabelaCervejaMobi.ViewModel
{
    public class ListaEstiloViewModel: BaseViewModel
    {
        private ICollection<EstiloCervejaViewModel> _estiloCerveja;
        private Command _verDetalhe;

        public Command VerDetalhe
        {
            get { return _verDetalhe; }
            set { _verDetalhe = value; }
        }

        public ICollection<EstiloCervejaViewModel> EstiloCerveja
        {
            get { return _estiloCerveja; }
            set
            {
                _estiloCerveja = value;
                OnPropertyChanging();
            }
        }
    }
}
