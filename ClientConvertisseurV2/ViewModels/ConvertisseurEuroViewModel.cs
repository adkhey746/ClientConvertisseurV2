using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConvertisseurV2.Models;
using ClientConvertisseurV2.Services;
using CommunityToolkit.Mvvm.Input;

namespace ClientConvertisseurV2.ViewModels
{
    public  class ConvertisseurEuroViewModel : Convertisseur
    {



        public ConvertisseurEuroViewModel()
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
                        TxtBoxMontantdevise = (Convert.ToDouble(TxtBoxMontantEuro) * Convert.ToDouble(laDevise.Taux)).ToString();
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
