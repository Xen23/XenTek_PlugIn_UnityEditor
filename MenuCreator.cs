using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI;

// XENTEK Global Namespace
namespace X23
{
    // Shared interface for all xCore controllers.
    // (Interfaces define a set of common methods and properties shared by all inheritors).
    public interface iXCoreController
    { 
            
    }
    public interface iXGUI
    {
    }

    // First function run after Unity splash.
    // Get device, platform, network, storage info..
    public class BOOTSTRAP
    {
        // Device
        // Platform
        // Command Line Options
        // .Exe directory config options
        // Unity Build
        // Application Name and Version.

        // LOAD INPUT / OUTPUT.
        // First (Scene 0) will be loaded by now.
    }

    public class USERIONDA
    {
        // 'I' :)
        // Keyboards, mouses, gamepads, joysticks, pen/touch inputs, cameras, scanners, microphones, accellerometers, geolocation, gyroscope, nunchukas
        // 'O'
        // Screens, glasses, headsets, haptics, audios, printers, rumblebpacks
        // 'N'
        // TCP+UDP/IP Transmission Control Protocol + User Datagram Protocol / Internet Protocol (Local Area Network & Internet Access)
        // Bluetooth I.P. + Devices
        // Near-field transmittors, modems, faxes, semaphone, smoke signals, cans-on-string and suchlike.
        // 'D'
        // Runtime directory, operating system program data directory, operating system temp directory,
        // Application data directory, operating system user data directory, os user temp directory,
        // Application streaming directory, application user directory.
        // All scene names, all material assets, models, sprites, textures, sounds, videos, animations, timelines, in project/app.
        // All loaded assetbundles, available asset bundles, versions, and update URL's on X23 server.
        // All loaded assemblies (.dlls), plug-in's, and 3rd party tools included in this XenTek application.
        // All available behaviours (Monobehaviour classes in the assemblies that can be put on GameObjects in Unity).
        // Assets and App and OS directory data trees, total install count.
        // Default Networking URL's for Master Server connection.
        // 
    }

    // Start the magick!
    public class XCORE : iXCoreController
    {
        public static void Main()
        {
            BOOTSTRAP BIOS = new BOOTSTRAP(); // Hardware and Operating System
            USERIONDA USER = new USERIONDA(); // User Input / Output devices, Networking, Display and Authorisation
  //          XENTEKAPP XAPP = new XENTEKAPP<BOOTSTRAP, USERIONDA>(BIOS, USER); // Varies. :)
        }

        public class XENTEKAPP<BOOTSTRAP, USERIONDA>
        {
            // Connect to API server.
            // Authorise connection.
            // Check versioning.
            // Run any updates.
            // Check if first load.
            // Release control to main application.
            public static void Main(BOOTSTRAP bios, USERIONDA user) 
            {
                //XENTEK X23 = new XENTEK(bios, user);
            }

            public class XENTEK : MonoBehaviour, iXCoreController
            {
                private BOOTSTRAP _b;
                private USERIONDA _u; 
                private string _a;

                public static void Main(BOOTSTRAP bios, USERIONDA user)
                {
                }

                public void Start(BOOTSTRAP b, USERIONDA u)
                {
                    string appId = Application.identifier;
                    this._b = b;
                    this._u = u;
                //    this._a = a;
                }
            }
        }
        /// <summary>
        /// Behaviour to save / retrieve a complex GUI structure
        /// and styling from game data via JSON data string.
        /// </summary>

        public class MenuCreator : MonoBehaviour, iXCoreController
        {
            string _menuJSONData = "";
            Dictionary<string, List<GameObject>> _menuStructure;
            string _readWriteDir;
    
            public Text text;
    
            void Start()
            {
                _menuStructure = new Dictionary<string, List<GameObject>>();
                _readWriteDir = Application.streamingAssetsPath; // Application.dataPath; // Application.persistentDataPath; // Application.temporaryCachePath; // Application.streamingAssetsPath
                //_menuJSONData = AssetBundle.LoadFromFileAsync(_readWriteDir + '/' + gameObject.name + "/.asset");
            }

            void Awake()
            {
            }
         
            void Update()
            {
        
            }
        }
}


}