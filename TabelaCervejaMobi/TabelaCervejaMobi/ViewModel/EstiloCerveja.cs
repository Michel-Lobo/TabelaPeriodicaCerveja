using System;
using System.Collections.Generic;
using System.Text;

namespace TabelaCervejaMobi.ViewModel
{
    public class EstiloCervejaViewModel: BaseViewModel
    {
        private int _idEstilo;
        private string _nomeGrupoEstilo;
        private string _nomeEstilo;
        private string _descricaoEstilo;
        private string _gravidadeInicial;
        private string _gravidadeFinal;
        private string _ibu;
        private string _abv;
        private string _srm;
        private string _exemplos;

        public string NomeGrupoEstilo
        {
            get { return _nomeGrupoEstilo; }
            set
            {
                _nomeGrupoEstilo = value;
                OnPropertyChanging();
            }
        }

        public string NomeEstilo
        {
            get { return _nomeEstilo; }
            set
            {
                _nomeEstilo = value;
                OnPropertyChanging();
            }
        }

        public string DescricaoEstilo
        {
            get { return _descricaoEstilo; }
            set
            {
                _descricaoEstilo = value;
                OnPropertyChanging();
            }
        }

        public string GravidadeInicial
        {
            get { return _gravidadeInicial; }
            set
            {
                _gravidadeInicial = value;
                OnPropertyChanging();
            }
        }

        public string GravidadeFinal
        {
            get { return _gravidadeFinal; }
            set
            {
                _gravidadeFinal = value;
                OnPropertyChanging();
            }
        }

        public string IBU
        {
            get { return _ibu; }
            set
            {
                _ibu = value;
                OnPropertyChanging();
            }
        }

        public string ABV
        {
            get { return _abv; }
            set
            {
                _abv = value;
                OnPropertyChanging();
            }
        }

        public string SRM
        {
            get { return _srm; }
            set
            {
                _srm = value;
                OnPropertyChanging();
            }
        }

        public string Exemplos
        {
            get { return _exemplos; }
            set
            {
                _exemplos = value;
                OnPropertyChanging();
            }
        }

        public int IDEstilo
        {
            get { return _idEstilo; }
            set
            {
                _idEstilo = value;
                OnPropertyChanging();
            }
        }

        public EstiloCervejaViewModel()
        {
            IDEstilo = 1;
            NomeEstilo = "Teste";
            NomeGrupoEstilo = " Teste Grupo";
        }
    }
}
