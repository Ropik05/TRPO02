using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTestProject1;

namespace UnitTestProject1
{
    [TestClass]
    public class Var_2Test
    {
        [TestMethod]
        public void Var2Test()
        {
            string название = "Тестовое название";
            byte количествоМест = 120;
            byte количествоОкон = 6;
            Var9Сотрудник сотрудник = new Var9Сотрудник(null,null,null,null);
            List<Var15Оборудование> оборудование = new List<Var15Оборудование>();
            Var10Должность должность = new Var10Должность(null,1200,null);
            Var11Подразделение подразделение = new Var11Подразделение(null,сотрудник,null);
            Var2Аудитория аудитория = new Var2Аудитория(название,сотрудник,количествоМест,количествоОкон,оборудование);

            string тестНазвание = аудитория.Название;
            byte тестКоличествоМест = аудитория.КоличествоПосадочныхМест;
            byte тестКоличествоОкон = аудитория.КоличествоОкон;
            List<Var15Оборудование> тестОборудование = аудитория.Оборудования;

            Assert.AreEqual(название, тестНазвание, "Ожидалось другое значение");
            Assert.AreEqual(количествоМест, тестКоличествоМест, "Ожидалось другое количество");
            Assert.AreEqual(количествоОкон, тестКоличествоОкон, "Ожидалось другое количество");
            Assert.AreEqual(тестОборудование, оборудование, "Ожидолось другое оборудование");
        }
    }
}
