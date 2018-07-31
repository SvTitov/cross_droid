using Android.App;
using Android.Runtime;
using Core;
using MvvmCross.Droid.Support.V7.AppCompat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Droid
{
    [Application]
    public class MainApplication : MvxAppCompatApplication<Setup, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
           : base(javaReference, transfer)
        {
        }
    }
}