namespace ST10445158_PROG6221_Part_1
{
    using System;

    class ResponseGenerator
    {
        public string Generate(string input)
        {
            if (input.Contains("hello"))
                return "Hi there! How can I assist you?";
            else if (input.Contains("how are you"))
                return "I'm just a bot, but I'm doing great!";
            else if (input.Contains("name"))
                return "I'm Cyber Aware Chatbot!";
            else if (input.Contains("purpose"))
                return "My purpose is to help you understand cyber security awareness!";
            else if (input.Contains("ask"))
                return "You can ask me about anything cyber security related";
            else if (input.Contains("time"))
                return $"The current time is {DateTime.Now:hh:mm tt}.";
            else if (input.Contains("phishing"))
                return "Phishing is a cyber attack where hackers impersonate legitimate sources to steal sensitive information. Always verify links before clicking!";
            else if (input.Contains("hi"))
                return "Hi there! How can I assist you?";
            else if (input.Contains("ransomware"))
                return "Ransomware is a type of malware that encrypts your files and demands a ransom. Avoid clicking suspicious links and always backup your data.";
            else if (input.Contains("strong password") || input.Contains("password"))
                return "A strong password is at least 12 characters long, includes uppercase and lowercase letters, numbers, and special characters.";
            else if (input.Contains("two-factor authentication") || input.Contains("2fa"))
                return "Two-factor authentication (2FA) adds an extra security layer by requiring a second verification step, like a code sent to your phone.";
            else if (input.Contains("Cyber Security"))
                return "the state of being protected against the criminal or unauthorized use of electronic data, or the measures taken to achieve this";
            else if (input.Contains("firewall"))
                return "A firewall is a security system that monitors and controls incoming and outgoing network traffic to prevent unauthorized access.";
            else if (input.Contains("vpn"))
                return "A VPN (Virtual Private Network) encrypts your internet connection, making it secure and private, especially on public Wi-Fi.";
            else if (input.Contains("social engineering"))
                return "Social engineering is the manipulation of people into divulging confidential information. Be skeptical of unexpected requests for personal info.";
            else if (input.Contains("malware"))
                return "Malware is any software designed to harm or exploit devices, networks, or users. Protect yourself with antivirus software and avoid suspicious links.";
            else if (input.Contains("zero-day attack"))
                return "A zero-day attack exploits unknown vulnerabilities before developers can release a fix. Keep software updated to reduce risk.";
            else if (input.Contains("how to stay safe online"))
                return "To stay safe online: Use strong passwords, enable 2FA, update software regularly, avoid public Wi-Fi without a VPN, and beware of phishing scams.";
            else if (input.Contains("cybersecurity best practices"))
                return "Cybersecurity best practices include using strong passwords, enabling firewalls, keeping software updated, and avoiding suspicious downloads.";
            else if (input.Contains("password manager"))
                return "A password manager securely stores and manages your passwords, reducing the risk of weak or reused passwords.";
            else if (input.Contains("public wifi"))
                return "Public Wi-Fi is risky because hackers can intercept your data. Use a VPN and avoid accessing sensitive accounts on public networks.";
            else if (input.Contains("identity theft"))
                return "Identity theft occurs when someone steals your personal information to commit fraud. Protect yourself by keeping sensitive info private.";
            else if (input.Contains("difference between virus and worm"))
                return "A virus needs a host file to spread, while a worm is self-replicating and spreads without user interaction.";
            else if (input.Contains("data breach"))
                return "A data breach is an unauthorized access of confidential data. Use strong passwords and 2FA to reduce risk.";
            else if (input.Contains("what is encryption"))
                return "Encryption converts information into a secure code to prevent unauthorized access. End-to-end encryption ensures data remains private.";
            else if (input.Contains("ddos attack"))
                return "A DDoS (Distributed Denial-of-Service) attack overwhelms a website or server with excessive traffic from multiple sources, making it inaccessible. Protect against it with rate limiting and cloud-based mitigation services.";
            else if (input.Contains("spear phishing"))
                return "Spear phishing is a targeted phishing attack aimed at specific individuals or organizations, often using personalized information to trick victims. Always verify the sender’s identity before sharing sensitive data.";
            else if (input.Contains("sql injection"))
                return "SQL injection is a cyberattack where hackers insert malicious SQL code into input fields to manipulate a database. Prevent it by using parameterized queries and input validation.";
            else if (input.Contains("antivirus"))
                return "Antivirus software detects and removes malware, such as viruses and ransomware, from your device. Keep it updated and run regular scans to stay protected.";
            else if (input.Contains("software update"))
                return "Software updates fix security vulnerabilities, improve performance, and add features. Install them promptly to protect against exploits like zero-day attacks.";
            else if (input.Contains("biometrics"))
                return "Biometrics use unique physical traits, like fingerprints or facial recognition, for authentication. They’re secure but should be paired with other methods, like passwords, for extra protection.";
            else if (input.Contains("dark web"))
                return "The dark web is a hidden part of the internet accessible only through special software, often used for illegal activities like selling stolen data. Avoid sharing personal information to reduce your risk.";
            else if (input.Contains("brute force attack"))
                return "A brute force attack tries countless password combinations to gain access to an account. Use strong, unique passwords and enable account lockouts to defend against it.";
            else if (input.Contains("secure browsing"))
                return "Secure browsing involves using HTTPS websites, avoiding suspicious links, enabling private browsing modes, and using browser extensions to block trackers and ads.";
            else if (input.Contains("man-in-the-middle"))
                return "A man-in-the-middle (MITM) attack intercepts communication between two parties to steal data or manipulate messages. Use encrypted connections like HTTPS and VPNs to prevent it.";
            else if (input.Contains("patch management"))
                return "Patch management involves regularly applying software updates to fix vulnerabilities. Automate patches and prioritize critical updates to reduce cyber risks.";
            else if (input.Contains("credential stuffing"))
                return "Credential stuffing uses stolen usernames and passwords from one site to access other accounts. Use unique passwords for each account and enable 2FA to protect yourself.";
            else
                return "I didn’t quite understand that. Could you rephrase?";
        }
    }
}