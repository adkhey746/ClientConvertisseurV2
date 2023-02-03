﻿using ClientConvertisseurV2.Models;
using ClientConvertisseurV2.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConvertisseurV2.ViewModels
{
    public abstract class Convertisseur: ObservableObject
    {
        private ObservableCollection<Devise> devises;

        public ObservableCollection<Devise> Devises
        {
            get { return devises; }
            set { devises = value; OnPropertyChanged(); }
        }

        private string txtBoxMontantEuro;

        public string TxtBoxMontantEuro
        {
            get => txtBoxMontantEuro;
            set => SetProperty(ref txtBoxMontantEuro, value);
        }

        private string txtBoxMontantdevise;

        public string TxtBoxMontantdevise
        {
            get => txtBoxMontantdevise;
            set => SetProperty(ref txtBoxMontantdevise, value);
        }

        private int laCombo;

        public int LaCombo
        {
            get => laCombo;
            set => SetProperty(ref laCombo, value);
        }
        public async void GetDataOnLoadAsync()
        {
            WSService service = new WSService("https://localhost:44340/api/");
            List<Devise> result = await service.GetDevisesAsync("devises");
            Devises = new ObservableCollection<Devise>(result);
        }
        public async void MessageAsync(string message, string title)
        {
            ContentDialog contentDialog = new ContentDialog()
            {
                Title = title,
                Content = message,
                CloseButtonText = "Ok"
            };

            contentDialog.XamlRoot = App.MainRoot.XamlRoot;
            await contentDialog.ShowAsync();
        }

    }
}
