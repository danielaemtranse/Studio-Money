using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Microsoft.Win32;  
using StudioByte.StudioMoney.Configuration.BE;
using StudioByte.StudioMoney.Configuration.Data;
using StudioByte.StudioMoney.Configuration.Business;

namespace Studio_Money.Classes
{
    public class clsSounds
    {

        [DllImport("winmm.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool PlaySound(string pszSound, IntPtr hMod, SoundFlags sf);

        // Flags for playing sounds.  For this example, we are reading 
        // the sound from a filename, so we need only specify 
        // SND_FILENAME | SND_ASYNC
        [Flags]
        public enum SoundFlags : int
        {
            SND_SYNC = 0x0000,  // play synchronously (default) 
            SND_ASYNC = 0x0001,  // play asynchronously 
            SND_NODEFAULT = 0x0002,  // silence (!default) if sound not found 
            SND_MEMORY = 0x0004,  // pszSound points to a memory file
            SND_LOOP = 0x0008,  // loop the sound until next sndPlaySound 
            SND_NOSTOP = 0x0010,  // don't stop any currently playing sound 
            SND_NOWAIT = 0x00002000, // don't wait if the driver is busy 
            SND_ALIAS = 0x00010000, // name is a registry alias 
            SND_ALIAS_ID = 0x00110000, // alias is a predefined ID
            SND_FILENAME = 0x00020000, // name is file name 
            SND_RESOURCE = 0x00040004  // name is resource name or atom 
        }

        public void fnPlay(string sEvent)
        {
            // Instantiate BE
            ConfigurationBE objBE = new ConfigurationBE();

            // Fill BE Properties
            if (System.Reflection.Assembly.GetExecutingAssembly().Location.IndexOf("bin") > 0)
            {
                objBE.sApplicationDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location.Remove(System.Reflection.Assembly.GetExecutingAssembly().Location.IndexOf("bin"), System.Reflection.Assembly.GetExecutingAssembly().Location.Length - System.Reflection.Assembly.GetExecutingAssembly().Location.IndexOf("bin"));
            }

            else
            {
                objBE.sApplicationDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            }

            objBE.sConfigurationINIFile = objBE.sApplicationDirectory + "Configuration\\StudioMoney.ini";

            // Instantiate business class
            Configuration objBusiness = new Configuration();

            // Fill properties of business class
            objBusiness.ObjConfigurationBE = objBE;

            // Instantiate sound class
            Studio_Money.Classes.clsSounds clsSounds = new Studio_Money.Classes.clsSounds();

            try
            {
                string wfname = objBusiness.fnGetSoundFile(sEvent);
                PlaySound(wfname, IntPtr.Zero, SoundFlags.SND_FILENAME | SoundFlags.SND_ASYNC);
            }

            catch
            {

            }

        }

    }   

}
