using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using HashLib;
using System.Security.Cryptography;
using System.Diagnostics.Metrics;

namespace HashWall
{
    public partial class TextHashingPage : Form
    {


        hashLogClass csvManager = new hashLogClass();
        hashingClass hash = new hashingClass();

        public TextHashingPage()
        {
            InitializeComponent();
        }

        private void hashInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hashComboBox.Text == "MD2")
            {
                IHash hasher = HashFactory.Crypto.CreateMD2();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String md2Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + md2Hash + "\r\n\r\n" + "Hash Type: " + "MD2";
            }
            else if (hashComboBox.Text == "MD4")
            {
                IHash hasher = HashFactory.Crypto.CreateMD4();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String md4Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + md4Hash + "\r\n\r\n" + "Hash Type: " + "MD4";
            }
            else if (hashComboBox.Text == "MD5")
            {
                
                IHash hasher = HashFactory.Crypto.CreateMD5();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String md5Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + md5Hash + "\r\n\r\n" + "Hash Type: " + "MD5";
            }
            else if (hashComboBox.Text == "SHA-1")
            {
                IHash hasher = HashFactory.Crypto.CreateSHA1();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String sha1Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + sha1Hash + "\r\n\r\n" + "Hash Type: " + "SHA-1";
            }
            else if (hashComboBox.Text == "SHA-224")
            {
                IHash hasher = HashFactory.Crypto.CreateSHA224();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String sha224Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + sha224Hash + "\r\n\r\n" + "Hash Type: " + "SHA-224";

            }
            else if (hashComboBox.Text == "SHA-256")
            {
                IHash hasher = HashFactory.Crypto.CreateSHA256();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String sha256Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + sha256Hash + "\r\n\r\n" + "Hash Type: " + "SHA-256";
            }
            else if (hashComboBox.Text == "SHA-384")
            {
                IHash hasher = HashFactory.Crypto.CreateSHA384();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String sha384Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + sha384Hash + "\r\n\r\n" + "Hash Type: " + "SHA-384";
            }
            else if (hashComboBox.Text == "SHA-512")
            {
                IHash hasher = HashFactory.Crypto.CreateSHA512();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String sha512Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + sha512Hash + "\r\n\r\n" + "Hash Type: " + "SHA-512";
            }
            else if (hashComboBox.Text == "RIPEMD128")
            {
                IHash hasher = HashFactory.Crypto.CreateRIPEMD128();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String ripeMD128Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + ripeMD128Hash + "\r\n\r\n" + "Hash Type: " + "RIPEMD128";
            }
            else if (hashComboBox.Text == "RIPEMD160")
            {
                IHash hasher = HashFactory.Crypto.CreateRIPEMD160();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String ripeMD160Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + ripeMD160Hash + "\r\n\r\n" + "Hash Type: " + "RIPEMD160";
            }
            else if (hashComboBox.Text == "RIPEMD256")
            {
                IHash hasher = HashFactory.Crypto.CreateRIPEMD256();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String ripeMD160Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + ripeMD160Hash + "\r\n\r\n" + "Hash Type: " + "RIPEMD256";
            }
            else if (hashComboBox.Text == "RIPEMD320")
            {
                IHash hasher = HashFactory.Crypto.CreateRIPEMD320();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String ripeMD160Hash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + ripeMD160Hash + "\r\n\r\n" + "Hash Type: " + "RIPEMD320";
            }
            else if (hashComboBox.Text == "Whirlpool")
            {
                IHash hasher = HashFactory.Crypto.CreateWhirlpool();
                HashResult r = hasher.ComputeString(hashInput.Text);
                String whirlpoolHash = r.ToString().Replace("-", "").ToLowerInvariant();
                hashTextResult.Text = "Result: " + whirlpoolHash + "\r\n\r\n" + "Hash Type: " + "Whirlpool";
            }
        }
    }
}
