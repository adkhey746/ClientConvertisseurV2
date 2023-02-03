using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientConvertisseurV2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientConvertisseurV2.Models;

namespace ClientConvertisseurV2.ViewModels.Tests
{
    [TestClass()]
    public class ConvertisseurEuroViewModelTests
    {

        [TestMethod()]
        public void ConvertisseurEuroViewModelTest()
        {
            ConvertisseurEuroViewModel convertisseurEuro = new ConvertisseurEuroViewModel();
            Assert.IsNotNull(convertisseurEuro);
        }

        [TestMethod()]
        public void GetDataOnLoadAsyncTest_OK()
        {
            //Arrange
            ConvertisseurEuroViewModel convertisseurEuro = new ConvertisseurEuroViewModel();
            //Act
            convertisseurEuro.GetDataOnLoadAsync();
            Thread.Sleep(1000);
            //Assert
            Devise dollar = new Devise(1, "Dollar", 1.08);
            Assert.AreEqual(dollar, convertisseurEuro.Devises[0]);

            Assert.IsNotNull(convertisseurEuro.Devises);
        }
        [TestMethod()]
        public void ActionSetConversionTest()
        {
            //Arrange
            //Création d'un objet de type ConvertisseurEuroViewModel
            ConvertisseurEuroViewModel convereuro = new ConvertisseurEuroViewModel();
            convereuro.GetDataOnLoadAsync();
            Thread.Sleep(1000); 
            //Property MontantEuro = 100 (par exemple)
            convereuro.TxtBoxMontantEuro = "100";

            //Création d'un objet Devise, dont Taux=1.07
            Devise ladev = new Devise(1, "Franc Suisse", 1.07);
            //Property DeviseSelectionnee = objet Devise instancié
            convereuro.LaCombo = ladev.Id;
            //Act
            //Appel de la méthode ActionSetConversion
            convereuro.ActionSetConversion();

            //Assert
            //Assertion : MontantDevise est égal à la valeur espérée 107
            Assert.AreEqual(convereuro.TxtBoxMontantdevise, "107");
        }

        [TestMethod()]
        public void GetDataOnLoadAsyncTest_Non_OK()
        {
            //Arrange
            ConvertisseurEuroViewModel convertisseurEuro = new ConvertisseurEuroViewModel();
            //Act
            convertisseurEuro.GetDataOnLoadAsync();
            Thread.Sleep(1000);
            //Assert
           

            Assert.IsNull(convertisseurEuro.Devises);
        }
    }
}