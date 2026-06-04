using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Config.Ini
{
    internal class IniParser
    {
        private readonly Dictionary<string, Dictionary<string, string>> _data = new();

        public IniParser(string path)
        {
            if (File.Exists(path))
            {
                Parse(path);
            }
        }

        private void Parse(string path)
        {
            string currentSection = "";
            foreach (var line in File.ReadLines(path, Encoding.UTF8))
            {
                var trimmed = line.Trim();
                if (trimmed.Length == 0 || trimmed.StartsWith(";") || trimmed.StartsWith("#"))
                {
                    continue;
                }

                if (trimmed.StartsWith("[") && trimmed.EndsWith("]"))
                {
                    currentSection = trimmed[1..^1].Trim();
                    _data.TryAdd(currentSection, new());
                }
                else if (trimmed.Contains('='))
                {
                    var idx = trimmed.IndexOf('=');
                    var key = trimmed[..idx].Trim();
                    var val = trimmed[(idx + 1)..].Trim();
                    if (!_data.ContainsKey(currentSection))
                    {
                        _data[currentSection] = new();
                    }
                    _data[currentSection][key] = val;
                }
            }
        }

        public void Save(string path)
        {
            var lines = new List<string>();
            foreach (var (section, keys) in _data)
            {
                lines.Add($"[{section}]");
                foreach (var (k, v) in keys)
                {
                    lines.Add($"{k}={v}");
                }

                lines.Add("");
            }
            File.WriteAllLines(path, lines, Encoding.UTF8);
        }

        public string Read(string section, string key)
        {
            return _data.TryGetValue(section, out var s) && s.TryGetValue(key, out var v) ? v : "";
        }

        public void Write(string section, string key, string value)
        {
            if (!_data.ContainsKey(section))
            {
                _data[section] = new();
            }

            _data[section][key] = value;
        }

        public bool KeyExists(string section, string key)
        {
            return _data.TryGetValue(section, out var s) && s.ContainsKey(key);
        }

        public void DeleteKey(string section, string key)
        {
            if (_data.TryGetValue(section, out var s))
            { 
                s.Remove(key);
            }
        }

        public void DeleteSection(string section)
        {
            _data.Remove(section);
        }
    }
    }
