﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SpecDrill;
using SpecDrill.SecondaryPorts.AutomationFramework;
using SpecDrill.WebControls;

namespace SomeTests.PageObjects.Test000
{
    public class Test000GatewayPage : WebPage
    {
        [Find(By.Id, "portal")]
        public IFrameElement<Test000LoginPage> FrmPortal;// { get; private set; }
        [Find(By.Id, "gwText")]
        public IElement LblGwText { get; private set; }

        [Find(By.XPath, @"//ul[@id = 'uList']/li")]
        public ListElement<WebControl> UList;
        //public Test000GatewayPage()
        //    : base(string.Empty)
        //{
        //    FrmPortal = WebElement.CreateFrame<Test000LoginPage>(this, ElementLocator.Create(By.Id, "portal"));
        //    LblGwText = WebElement.Create(this, ElementLocator.Create(By.Id, "gwText"));
        //}
    }
}
