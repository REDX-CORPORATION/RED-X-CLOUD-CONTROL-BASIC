# ☁️ RED-X CLOUD CONTROL BASIC

> 🚀 **Basic version of the RED-X remote control system**  
> Control a Windows application or trigger logic **remotely from your phone or browser** using just a local HTML file and your PC's IPv4 address.

---

## 📄 About This Project

**RED-X CLOUD CONTROL BASIC** is a simplified version of the RED-X remote control system.  
Instead of running a full C# server, the user just edits an **HTML file** by replacing the IP address with their own **host PC’s IPv4**, and then uses that file from any other device on the same Wi-Fi network to trigger actions.

This is great for:
- ✅ Beginners learning HTML + local networking
- ✅ Lightweight setups
- ✅ Mobile/remote triggers without needing a backend

---

## 🌟 How It Works

- You are given a `RED-X CLOUD CONTROL BASIC.html` file.
- Open it in any browser (mobile/PC) connected to the same Wi-Fi as the host PC.
- The buttons send HTTP requests to the host computer's IP + port.
- These requests trigger specific actions (like toggling cheats, scripts, or aimbot, depending on what the host EXE supports).

---

## 🔧 Setup Instructions

### 1. Find Your Host Computer's IPv4

1. On your PC, press `Windows + R`, type `cmd`, and press Enter  
2. In the Command Prompt, type:

   ```
   ipconfig
   ```

3. Look for your **IPv4 address** under Wi-Fi or Ethernet, like:

   ```
   IPv4 Address. . . . . . . . . . : 192.168.0.214
   ```

---

### 2. Edit the HTML File

- Open the provided `RED-X CLOUD CONTROL BASIC.html` in any text editor (e.g., Notepad)
- Replace the placeholder IP address in the script or action URLs with **your real IPv4 address**
  
For example:

```html
fetch("http://192.168.X.X:6969/aimbot")
```

> 🔁 Replace `192.168.X.X` with your PC’s actual IP

---

### 3. Open the HTML File on Your Mobile or Browser

- Make sure your phone is on the **same Wi-Fi** as your PC
- Send the `RED-X CLOUD CONTROL BASIC.html` to your phone (via Telegram, WhatsApp, or USB)
- Open it in any mobile browser

✅ Clicking a button will now send a command to your PC EXE through the local network

---

## 💡 Use Case

- 📱 Control game cheats from your phone
- 🖱️ Trigger PC logic remotely via simple buttons
- 🧪 Learn HTML-to-PC communication without needing backend code

---

## 📦 What’s Included

- `RED-X CLOUD CONTROL BASIC.html` – The control panel interface
- Easy editing instructions inside the file comments

---

## 🙏 Credits

> This project is a **lightweight and open HTML frontend** made for RED-X control systems.  
> Created by **Mohtasim Billah Jitu (RED-X CORPORATION)**.

If you use this or build something from it, **a credit would mean a lot** 💖

---

## 👑 RED-X CORPORATION

- 💬 Discord: [Join RED-X Server](https://discord.gg/f7KPc9JyeY)
- 📢 Telegram: [Follow Our Channel](https://t.me/+OglBPVcrngY1OGQ9)
- 📸 Instagram: [@mohtasimjitu](https://www.instagram.com/mohtasimjitu/)

> Built with ❤️ by RED-X CORPORATION  
> For help, suggestions, or collab, feel free to reach out.

---

© 2025 RED-X CORPORATION. All rights reserved.
