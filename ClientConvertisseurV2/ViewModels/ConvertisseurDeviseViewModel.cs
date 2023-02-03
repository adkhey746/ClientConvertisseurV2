using ClientConvertisseurV2.Models;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConvertisseurV2.ViewModels
{
    public class ConvertisseurDeviseViewModel:Convertisseur
    {

        public ConvertisseurDeviseViewModel()
        {
            GetDataOnLoadAsync();

            //bouttons
            BtnSetConversion = new RelayCommand(ActionSetConversion);
        }

        public IRelayCommand BtnSetConversion { get; }
        public void ActionSetConversion()
        {
            //Code du calcul à écrire

            try
            {
                if (LaCombo == -1)
                {
                    MessageAsync("Vous devez sélectionner une devise !", "Erreur");
                }
                foreach (Devise laDevise in Devises)
                {
                    if (laDevise.Id == LaCombo + 1)
                    {
                        TxtBoxMontantEuro = (Convert.ToDouble(TxtBoxMontantdevise) / Convert.ToDouble(laDevise.Taux)).ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageAsync("Impossible de calculer le montant !", "Erreur");
            }
        }
    }
}
