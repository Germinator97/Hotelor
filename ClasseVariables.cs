using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE_Application
{
    class ClassVariable
    {
        #region variables
        //variable de la TxtboxNom
        private string _ServiceAjouter;

        //variable de la TxtboxPrenom
        private string _RechercheArchives;

        //variable de la ComboClass
        private string _LoginAuthentification;

        //variable de la ComboClass
        private string _PassAuthentification;

        //variable de la ComboClass
        private string _NouveauLoginConfiguration;

        //variable de la ComboClass
        private string _AncienLoginConfiguration;

        //variable de la ComboClass
        private string _NouveauPassConfiguration;

        //variable de la ComboClass
        private string _AncienPassConfiguration;

        //variable de la ComboClass
        private string _NouveauPassConfirmationConfiguration;

        //variable de la ComboClass
        private string _ChambreConfiguration;

        //variable de la ComboClass
        private string _NomsDemandes;

        //variable de la ComboClass
        private string _PrenomsDemandes;

        //variable de la ComboClass
        private string _ContactsDemandes;

        //variable de la ComboClass
        private string _MailDemandes;

        //variable de la ComboClass
        private string _AdresseDemandes;

        //variable de la ComboClass
        private string _ChambreDemandes;

        //variable de la ComboClass
        private string _ContactDemandes;

        //variable de la ComboClass
        private string _CarteDemandes;

        //variable de la ComboClass
        private string _BonusDemandes;

        //variable de la ComboClass
        private string _MontantDemandes;

        //variable de la ComboClass
        private string _SortieDemandes;

        //variable de la ComboClass
        private string _RechercheMenu;

        //variable de la ComboClass
        private string _NomsPertes;

        //variable de la ComboClass
        private string _ChambrePertes;

        //variable de la ComboClass
        private string _ArticlesPertes;

        //variable de la ComboClass
        private string _NumeroRecu;

        //variable de la ComboClass
        private string _DateRecu;

        //variable de la ComboClass
        private string _NomsRecu;

        //variable de la ComboClass
        private string _ChambreRecu;

        //variable de la ComboClass
        private string _SortieRecu;

        //variable de la ComboClass
        private string _PaiementRecu;

        //variable de la ComboClass
        private string _BonusRecu;

        //variable de la ComboClass
        private string _MontantRecu;

        //variable de la ComboClass
        private string _NomsServices;

        //variable de la ComboClass
        private string _ChambreServices;

        //variable de la ComboClass
        private string _ServiceServices;

        //variable de la ComboClass
        private string _RechercheSorties;

        #endregion


        #region property

        public string ServiceAjouter
        {
            get
            {
                return this._ServiceAjouter;
            }
            set
            {
                this._ServiceAjouter = value;
            }
        }

        public string RechercheArchives
        {
            get
            {
                return this._RechercheArchives;
            }
            set
            {
                this._RechercheArchives = value;
            }
        }

        public string LoginAuthentification
        {
            get
            {
                return this._LoginAuthentification;
            }
            set
            {
                this._LoginAuthentification = value;
            }
        }

        public string PassAuthentification
        {
            get
            {
                return this._PassAuthentification;
            }
            set
            {
                this._PassAuthentification = value;
            }
        }

        public string NouveauLoginConfiguration
        {
            get
            {
                return this._NouveauLoginConfiguration;
            }
            set
            {
                this._NouveauLoginConfiguration = value;
            }
        }

        public string AncienLoginConfiguration
        {
            get
            {
                return this._AncienLoginConfiguration;
            }
            set
            {
                this._AncienLoginConfiguration = value;
            }
        }

        public string NouveauPassConfiguration
        {
            get
            {
                return this._NouveauPassConfiguration;
            }
            set
            {
                this._NouveauPassConfiguration = value;
            }
        }

        public string AncienPassConfiguration
        {
            get
            {
                return this._AncienPassConfiguration;
            }
            set
            {
                this._AncienPassConfiguration = value;
            }
        }

        public string NouveauPassConfirmationConfiguration
        {
            get
            {
                return this._NouveauPassConfirmationConfiguration;
            }
            set
            {
                this._NouveauPassConfirmationConfiguration = value;
            }
        }

        public string ChambreConfiguration
        {
            get
            {
                return this._ChambreConfiguration;
            }
            set
            {
                this._ChambreConfiguration = value;
            }
        }

        public string NomsDemandes
        {
            get
            {
                return this._NomsDemandes;
            }
            set
            {
                this._NomsDemandes = value;
            }
        }

        public string PrenomsDemandes
        {
            get
            {
                return this._PrenomsDemandes;
            }
            set
            {
                this._PrenomsDemandes = value;
            }
        }

        public string ContactsDemandes
        {
            get
            {
                return this._ContactsDemandes;
            }
            set
            {
                this._ContactsDemandes = value;
            }
        }

        public string MailDemandes
        {
            get
            {
                return this._MailDemandes;
            }
            set
            {
                this._MailDemandes = value;
            }
        }

        public string AdresseDemandes
        {
            get
            {
                return this._AdresseDemandes;
            }
            set
            {
                this._AdresseDemandes = value;
            }
        }

        public string ChambreDemandes
        {
            get
            {
                return this._ChambreDemandes;
            }
            set
            {
                this._ChambreDemandes = value;
            }
        }

        public string ContactDemandes
        {
            get
            {
                return this._ContactDemandes;
            }
            set
            {
                this._ContactDemandes = value;
            }
        }

        public string CarteDemandes
        {
            get
            {
                return this._CarteDemandes;
            }
            set
            {
                this._CarteDemandes = value;
            }
        }

        public string BonusDemandes
        {
            get
            {
                return this._BonusDemandes;
            }
            set
            {
                this._BonusDemandes = value;
            }
        }

        public string MontantDemandes
        {
            get
            {
                return this._MontantDemandes;
            }
            set
            {
                this._MontantDemandes = value;
            }
        }

        public string SortieDemandes
        {
            get
            {
                return this._SortieDemandes;
            }
            set
            {
                this._SortieDemandes = value;
            }
        }

        public string RechercheMenu
        {
            get
            {
                return this._RechercheMenu;
            }
            set
            {
                this._RechercheMenu = value;
            }
        }

        public string NomsPertes
        {
            get
            {
                return this._NomsPertes;
            }
            set
            {
                this._NomsPertes = value;
            }
        }

        public string ChambrePertes
        {
            get
            {
                return this._ChambrePertes;
            }
            set
            {
                this._ChambrePertes = value;
            }
        }

        public string ArticlesPertes
        {
            get
            {
                return this._ArticlesPertes;
            }
            set
            {
                this._ArticlesPertes = value;
            }
        }

        public string BonusRecu
        {
            get
            {
                return this._BonusRecu;
            }
            set
            {
                this._BonusRecu = value;
            }
        }

        public string ChambreRecu
        {
            get
            {
                return this._ChambreRecu;
            }
            set
            {
                this._ChambreRecu = value;
            }
        }

        public string DateRecu
        {
            get
            {
                return this._DateRecu;
            }
            set
            {
                this._DateRecu = value;
            }
        }

        public string MontantRecu
        {
            get
            {
                return this._MontantRecu;
            }
            set
            {
                this._MontantRecu = value;
            }
        }

        public string NomsRecu
        {
            get
            {
                return this._NomsRecu;
            }
            set
            {
                this._NomsRecu = value;
            }
        }

        public string NumeroRecu
        {
            get
            {
                return this._NumeroRecu;
            }
            set
            {
                this._NumeroRecu = value;
            }
        }

        public string PaiementRecu
        {
            get
            {
                return this._PaiementRecu;
            }
            set
            {
                this._PaiementRecu = value;
            }
        }

        public string SortieRecu
        {
            get
            {
                return this._SortieRecu;
            }
            set
            {
                this._SortieRecu = value;
            }
        }

        public string ChambreServices
        {
            get
            {
                return this._ChambreServices;
            }
            set
            {
                this._ChambreServices = value;
            }
        }

        public string NomsServices
        {
            get
            {
                return this._NomsServices;
            }
            set
            {
                this._NomsServices = value;
            }
        }

        public string ServiceServices
        {
            get
            {
                return this._ServiceServices;
            }
            set
            {
                this._ServiceServices = value;
            }
        }

        public string RechercheSorties
        {
            get
            {
                return this._RechercheSorties;
            }
            set
            {
                this._RechercheSorties = value;
            }
        }

        #endregion
    }
}
