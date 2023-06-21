# Advanced Topics in Cyber Security - Antivirus Project

The final project for the Advanced Topics in Cyber Security course at Ruppin Academic Center.
The project focuses on developing an antivirus program capable of detecting malicious activity on a local machine running in a virtual machine.
The goal is to successfully detect threats simulated by a program provided by the lecturer.

# Implementation

The antivirus program is implemented in C# using the .NET Framework and is designed to run on Windows. 
Additionally, the user interface is implemented with a C# Form application to provide an intuitive and interactive experience for users.

# Antivirus Functionality

1. Automatic Startup: The antivirus program runs automatically on startup and remains active until shutdown.

2. User Interface: The antivirus program provides a user interface that allows interaction with the antivirus.

3. User-Initiated Scan: The antivirus program allows users to manually initiate scans on specific directories or individual files. Suspicious files are flagged and reported.

4. Reactive Scan: The antivirus program monitors the system for high-risk events, such as registry key creation or file creation in specific directories. When such events are detected, the corresponding file is automatically scanned for potential threats.

5. Expert Mode: The antivirus program includes an expert mode that provides detailed output explaining why a file was flagged as malicious or non-malicious.

6. Log File: The antivirus program generates a detailed log file during scans. The log file provides full technical details of the scan results, including information about both malicious and non-malicious files.
   To maintain data integrity, the log file is locked during the execution of the antivirus program, allowing only authorized write access.

# User Interface
<img width="934" alt="expertmode" src="https://github.com/Moshemena/Antivirus/assets/99141505/03f71f87-c58c-437a-b4d7-e85abb240ac0">


