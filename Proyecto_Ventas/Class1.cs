using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias que se agragaron
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace Proyecto_Ventas
{
    class CrearTicket
    {

        StringBuilder linea = new StringBuilder();
        int maxCar = 40;
        int cortar;

        public string lineasGuion()
        {
            string lineasGuion = "";

            for (int j = 0; j < maxCar; j++)
            {
                lineasGuion += "-";
            }

            return linea.AppendLine(lineasGuion).ToString();
        }

        public string lineasAsteriscos()
        {
            string lineasAsteriscos = "";

            for (int j = 0; j < maxCar; j++)
            {
                lineasAsteriscos += "*";
            }

            return linea.AppendLine(lineasAsteriscos).ToString();
        }

        public string lineasIgual()
        {
            string lineasIgual = "";

            for (int j = 0; j < maxCar; j++)
            {
                lineasIgual += "=";
            }

            return linea.AppendLine(lineasIgual).ToString();
        }

        public void EncabezadoVenta()
        {
            linea.AppendLine("ARTICULO         |CANT|PRECIO|IMPORTANTE");
        }

        public void TextoIzquierda(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }

                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                linea.AppendLine(texto);
            }
            
        }

        public void TextoDerecha(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                string espacios = "";
                for (int j = 0; j < (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length); j++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                for (int j = 0; j < (maxCar - texto.Length); j++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto);
            }

        }

        public void TextoCentrado(string texto)
        {
            if (texto.Length > maxCar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxCar; longitudTexto -= maxCar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxCar));
                    caracterActual += maxCar;
                }
                string espacios = "";
                int centrar = (maxCar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;

                for (int j = 0; j < centrar; j++)
                {
                    espacios += " ";
                }

                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                int centrar = (maxCar - texto.Length) / 2;
                for (int j = 0; j < centrar ; j++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto);
            }

        }

        public void TextoExtremos(string textoIzquierdo, string textoDerecho)
        {
            string textoIzq;
            string textoDer;
            string textoCompleto = "";
            string espacios = "";

            if (textoIzquierdo.Length > 18)
            {
                cortar = textoIzquierdo.Length - 18;
                textoIzq = textoIzquierdo.Remove(18, cortar);
            }
            else { textoIzq = textoIzquierdo; }

            textoCompleto = textoIzq;

            if (textoDerecho.Length > 20)
            {
                cortar = textoDerecho.Length - 20;
                textoDer = textoIzquierdo.Remove(20, cortar);
            }
            else { textoDer = textoDerecho; }

            int nroEspacios = maxCar - (textoIzquierdo.Length - textoDerecho.Length);
            for (int j = 0; j < nroEspacios; j++)
            {
                espacios = " ";
            }
            textoCompleto += espacios + textoDer;
            linea.AppendLine(textoCompleto);
        }

        public void AgregarTotales(string texto, decimal total)
        {
            string resumen;
            string valor;
            string textoCompleto = "";
            string espacios = "";

            if (texto.Length >25)
            {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25, cortar);
            }
            else { resumen = texto; }

            textoCompleto = resumen;
            valor = total.ToString("#,#.00");

            int nroEspacios = maxCar - (resumen.Length + valor.Length);

            for (int j = 0; j < nroEspacios; j++)
            {
                espacios += " ";
            }
            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);

        }

        public void AgregarArticulos(string articulo, int cant, decimal precio, decimal importe)
        {

            if (cant.ToString().Length <= 5 && precio.ToString().Length <=7 && importe.ToString().Length <= 8)
            {
                string elemento = "";
                string espacios = "";
                bool bandera = false;
                int nroEspacios = 0;

                if (articulo.Length > 20)
                {
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int j = 0; j < nroEspacios; j++)
                    {
                        espacios = " ";
                    }

                    elemento += espacios + cant.ToString();

                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int j = 0; j < nroEspacios; j++)
                    {
                        espacios = " ";
                    }

                    elemento += espacios + precio.ToString();

                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int j = 0; j < nroEspacios; j++)
                    {
                        espacios = " ";
                    }

                    elemento += espacios + importe.ToString();

                    int caracterActual = 0;
                    for (int longitudtexto = articulo.Length; longitudtexto >20; longitudtexto -= 20)
                    {
                        if (bandera==false)
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 20) + elemento);
                            bandera = true;
                        }
                        else
                        {
                            linea.AppendLine(articulo.Substring(caracterActual, 20));
                            caracterActual += 20;
                        }

                        linea.AppendLine(articulo.Substring(caracterActual, articulo.Length - caracterActual)); 
                    }
                }
                else
                {
                    for (int j = 0; j < (20 - articulo.Length); j++)
                    {
                        espacios += " ";
                    }

                    elemento = articulo + espacios;

                    nroEspacios = (2 - cant.ToString().Length);
                    espacios = "";
                    for (int j = 0; j < nroEspacios; j++)
                    {
                        espacios += " ";
                    }

                    elemento += espacios + cant.ToString();

                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int j = 0; j < nroEspacios; j++)
                    {
                        espacios += " ";
                    }

                    elemento += espacios + precio.ToString();

                    nroEspacios = (10 - importe.ToString().Length);
                    espacios = "";
                    for (int j = 0; j < nroEspacios; j++)
                    {
                        espacios += " ";
                    }

                    elemento += espacios + importe.ToString();

                    linea.AppendLine(elemento);
                }
            }
            else
            {
                linea.AppendLine("Los valores ingresados para esta fila");
                linea.AppendLine("superan las columnas soportadas para este.");
                throw new Exception("Los valores ingresados para algunas filas del Ticket\nsuperan las columnas soportadas para este."); 
            }
        }
        //metodos para enviar secuencias de escape a la impresora

        public void CortarTicket()
        {
            linea.AppendLine("\x1B" + "m"); //caracteres de corte. estos caracateres varian segun la impresora
            linea.AppendLine("\x1B" + "d" + "\x09");//avanza 9 renglones
        }

        public void AbreCajon()
        {
            linea.AppendLine("\x1B" + "p" + "\x00" + "\x0F" + "\x96");//caracteres de apertura del cajon 0
            //linea.AppendLine("\x1B" + "p" + "\x01" + "\x0F" + "\x96");//caracteres de apertura del cajon 1

        }

        public void ImprimirTicket(string impresora)
        {
            //este metodo recibe el nombre de la impresora en la cual imprimieremos el texto
            //codigo de microsoft http://suport.microsoft.com/es-es/kb/322091

            RawPrinterHelper.SendStringToPrinter(impresora, linea.ToString());
            linea.Clear();
        }
    }


    //clase descargada desde internet que ayuda a mediar entre los dispositivos de harware (impresora y pc)
    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "Ticket de Venta";
            // Win7
            di.pDataType = "RAW";

            // Win8+
            // di.pDataType = "XPS_PASS";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            fs.Close();
            fs.Dispose();
            fs = null;
            return bSuccess;
        }
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }
}
