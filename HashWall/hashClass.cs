using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using System.IO;
using HashWall;
using System.Security.Policy;
using System.Drawing.Text;
using System.Windows.Forms;
using HashLib;


namespace HashWall
{
    public class hashingClass
    {
        hashLogClass csvManager = new hashLogClass();

        public string CalculateMDHashofFile(string filePath, int hashType)
        {
            using (var stream = File.OpenRead(filePath))
            {

                if (hashType == 2)
                {
                    IHash hasher = HashFactory.Crypto.CreateMD2();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();

                }
                else if (hashType == 4)
                {
                    IHash hasher = HashFactory.Crypto.CreateMD4();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }
                else if (hashType == 5)
                {
                    IHash hasher = HashFactory.Crypto.CreateMD5();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }

                return "0"; // CS8603 hayatımı bitirdi
            }
        }
        public string CalculateSHAHashofFile(string filePath, int hashType)
        {
            using (var stream = File.OpenRead(filePath))
            {
                if (hashType == 1)
                {
                    using (var sha1 = SHA1.Create())
                    {
                        byte[] hash = sha1.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
                else if (hashType == 224)
                {
                    IHash hasher = HashFactory.Crypto.CreateSHA224();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }
                else if (hashType == 256)
                {
                    using (var sha256 = SHA256.Create())
                    {
                        byte[] hash = sha256.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
                else if (hashType == 384)
                {
                    using (var sha384 = SHA384.Create())
                    {
                        byte[] hash = sha384.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
                else if (hashType == 512)
                {
                    using (var sha512 = SHA512.Create())
                    {
                        byte[] hash = sha512.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            return "0";
        }

        public string CalculateWhirlPoolofFile(string filePath)
        {
            using (var stream = File.OpenRead(filePath))
            {
                IHash hasher = HashFactory.Crypto.CreateWhirlpool();
                HashResult r = hasher.ComputeStream(stream);
                return r.ToString().Replace("-", "").ToLowerInvariant();
            }
        }
        public string CalculateRIPEMDofFile(string filePath, int hashType)
        {
            if (hashType == 128)
            {
                using (var stream = File.OpenRead(filePath))
                {
                    IHash hasher = HashFactory.Crypto.CreateRIPEMD128();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }
            }
            else if (hashType == 160)
            {
                using (var stream = File.OpenRead(filePath))
                {
                    IHash hasher = HashFactory.Crypto.CreateRIPEMD160();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }
            }
            else if (hashType == 256)
            {
                using (var stream = File.OpenRead(filePath))
                {
                    IHash hasher = HashFactory.Crypto.CreateRIPEMD256();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }
            }
            else if (hashType == 320)
            {
                using (var stream = File.OpenRead(filePath))
                {
                    IHash hasher = HashFactory.Crypto.CreateRIPEMD320();
                    HashResult r = hasher.ComputeStream(stream);
                    return r.ToString().Replace("-", "").ToLowerInvariant();
                }
            }
            return "0";
        }
        public string outputText = "";
        public string hashAll(string selectedFileName, string safeSelectedFileName)
        {
            outputText = "";

            string md2Hash = CalculateMDHashofFile(selectedFileName, 2);
            outputText += "File: " + safeSelectedFileName + " MD2: " + md2Hash + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "MD2", md2Hash, DateTime.Now);

            string md4Hash = CalculateMDHashofFile(selectedFileName, 4);
            outputText += "File: " + safeSelectedFileName + " MD4: " + md4Hash + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "MD4", md4Hash, DateTime.Now);

            string md5Hash = CalculateMDHashofFile(selectedFileName, 5);
            outputText += "File: " + safeSelectedFileName + " MD5: " + md5Hash + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "MD5", md5Hash, DateTime.Now);

            string sha1Hash = CalculateSHAHashofFile(selectedFileName, 1);
            outputText += "File: " + safeSelectedFileName + " SHA1: " + sha1Hash + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "SHA1", sha1Hash, DateTime.Now);

            string sha224Hash = CalculateSHAHashofFile(selectedFileName, 224);
            outputText += "File: " + safeSelectedFileName + " SHA-224: " + sha224Hash + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "SHA-224", sha224Hash, DateTime.Now);

            string sha256Hash = CalculateSHAHashofFile(selectedFileName, 256);
            outputText += "File: " + safeSelectedFileName + " SHA-256: " + sha256Hash + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "SHA-256", sha256Hash, DateTime.Now);

            string sha384Hash = CalculateSHAHashofFile(selectedFileName, 384);
            outputText += "File: " + safeSelectedFileName + " SHA-384: " + sha384Hash + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "SHA-384", sha384Hash, DateTime.Now);

            string sha512Hash = CalculateSHAHashofFile(selectedFileName, 512);
            outputText += "File: " + safeSelectedFileName + " SHA-512: " + sha512Hash + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "SHA-512", sha512Hash, DateTime.Now);

            string whirlpoolHash = CalculateWhirlPoolofFile(selectedFileName);
            outputText += "File: " + safeSelectedFileName + " Whirlpool: " + whirlpoolHash + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "Whirlpool", whirlpoolHash, DateTime.Now);

            string ripeMD128 = CalculateRIPEMDofFile(selectedFileName, 128);
            outputText += "File: " + safeSelectedFileName + " RIPEMD-128: " + ripeMD128 + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-128", ripeMD128, DateTime.Now);

            string ripeMD160 = CalculateRIPEMDofFile(selectedFileName, 160);
            outputText += "File: " + safeSelectedFileName + " RIPEMD-160: " + ripeMD160 + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-160", ripeMD128, DateTime.Now);

            string ripeMD256 = CalculateRIPEMDofFile(selectedFileName, 256);
            outputText += "File: " + safeSelectedFileName + " RIPEMD-256: " + ripeMD256 + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-256", ripeMD256, DateTime.Now);

            string ripeMD320 = CalculateRIPEMDofFile(selectedFileName, 320);
            outputText += "File: " + safeSelectedFileName + " RIPEMD-320: " + ripeMD320 + "\n";
            csvManager.WriteToCsv(safeSelectedFileName, "RIPEMD-320", ripeMD320, DateTime.Now);

            return outputText;
        }

    }
}
