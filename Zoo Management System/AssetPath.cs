using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ZooManagementSystem
{
    /// <summary>
    /// Finds pictures and media wherever the project is copied to. The database and some
    /// forms store absolute paths from one laptop, or paths relative to the project folder;
    /// this looks for the file next to the .exe, in the project folder above it, and by
    /// file name in Resources, Resources\ShopPic and Photos\AnimalImages.
    /// </summary>
    internal static class AssetPath
    {
        private static readonly string[] Folders = { "", "Resources", @"Resources\ShopPic", @"Photos\AnimalImages", "Photos" };

        /// <summary>Full path of an existing file, or null when it cannot be found.</summary>
        public static string Find(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return null;
            string clean = path.Replace("\"", "").Replace('/', '\\').Trim();

            try
            {
                if (Path.IsPathRooted(clean) && File.Exists(clean)) return clean;
            }
            catch (ArgumentException) { }

            string name;
            try { name = Path.GetFileName(clean); }
            catch (ArgumentException) { return null; }
            if (string.IsNullOrEmpty(name)) return null;

            // bin\Debug → project folder → solution folder
            var dir = new DirectoryInfo(Application.StartupPath);
            for (int up = 0; dir != null && up < 5; up++, dir = dir.Parent)
            {
                try
                {
                    if (!Path.IsPathRooted(clean))
                    {
                        string relative = Path.Combine(dir.FullName, clean);
                        if (File.Exists(relative)) return relative;
                    }
                }
                catch (ArgumentException) { }

                foreach (string folder in Folders)
                {
                    string candidate = Path.Combine(dir.FullName, folder, name);
                    if (File.Exists(candidate)) return candidate;
                }
            }
            return null;
        }

        /// <summary>Loads an image without locking the file, or returns null when it is missing.</summary>
        public static Image Load(string path)
        {
            string found = Find(path);
            if (found == null) return null;
            try
            {
                using (var stream = new MemoryStream(File.ReadAllBytes(found)))
                using (var image = Image.FromStream(stream))
                    return new Bitmap(image);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
