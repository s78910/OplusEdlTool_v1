# OPLUS EDL Tool v1

An open-source EDL mode flashing tool for OPLUS phones, supporting most OPLUS smartphone EDL mode operations.

**English Version | [中文版本](README.md)**

## ⚠️ Important Notice

**This tool is for technical research and development purposes only. Using this tool may result in device damage, data loss, or warranty voidance. Please fully understand the associated risks before use. The developers are not responsible for any losses caused by using this tool.**

## 🚀 Features

### Current Version (v1)
- ✅ EDL mode detection and connection
- ✅ Firehose protocol support
- ✅ Partition table read/write
- ✅ XML configuration file processing
- ✅ Partition cleanup functionality
- ✅ Multi-language support (English/Chinese)
- ✅ Graphical user interface
- ✅ Administrator privileges required

### Supported Phone Models
- Supports most OPLUS phones in EDL mode
- Some newer models require user testing, compatibility not guaranteed

## 📋 System Requirements

- Windows 7/8/10/11 (64-bit recommended)
- .NET 8.0 Runtime
- Administrator privileges
- USB 2.0/3.0 interface

## 🔧 Installation & Usage

### Quick Start
1. Download the latest release package
2. Extract to any directory
3. Right-click `OplusEdlTool.exe` → "Run as administrator"
4. Put phone into EDL mode and connect to computer
5. Follow on-screen instructions

### Entering EDL Mode
Methods vary by device model, common methods:
- Power off completely, hold Volume Up & Down while inserting USB cable
- Using ADB command: `adb reboot edl`
- Using fastboot command: `fastboot oem edl`

## 📖 Usage Instructions

### Software Screenshots
![Main Interface](picture/mainwindow.png)
*Main application interface showing all available functions*

#### Function Usage
![Function Usage](picture/pic2.jpg)
*Function usage related screenshots*

### Main Interface Functions
- **Firehose**: Firehose protocol operations
- **Partitions**: Partition management
- **Read XML**: Read XML configurations
- **Write XML**: Write XML configurations
- **Cleanup**: Partition cleanup

### Precautions
- Backup important data before operations
- Ensure sufficient phone battery (recommend 50%+)
- Use original or high-quality USB cable
- Do not disconnect during operation

## 🔄 Version Information

### v1 Version
- Current open-source version
- Supports most mainstream OPLUS phones
- Basic functionality complete

### v2 Version
For advanced v2 version, please visit:
**https://static-tcdn.anteasy.com/xasdun/upload-log/oet-upload.html**

v2 version may include:
- Broader device support
- Advanced features
- Professional technical support

## 🛠️ Build Instructions

### Development Environment
- Visual Studio 2022 or higher
- .NET 8.0 SDK
- Windows SDK

### Build Steps
```bash
# Clone repository
git clone https://github.com/salokrwhite/OplusEdlTool.git

# Enter project directory
cd OplusEdlTool

# Restore dependencies
dotnet restore

# Build project
dotnet build -c Release
```

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## 📞 Support & Feedback

- Submit Issues: [GitHub Issues](https://github.com/salokrwhite/OplusEdlTool/issues)

## ⚖️ Legal Statement

This tool is for educational and research purposes only. Users should comply with local laws and regulations and not use it for any illegal activities. Developers are not responsible for misuse of the tool.

---

**⭐ If this project is helpful to you, please give it a Star for support!**