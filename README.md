# What is Information Gatherer?
Information Gatherer is a basic C# app made in Visual Studio 2019 for people who use VPNs. The purpose is to put all DNS/IP leak test sites
centrilized in one spot to make it easier to manage the DNS/IP sites you use - the sites used are popular sites among VPN users. There is 
the "Check if IP Matches Whats my IP" button on the app that is part of the app -- not like the other buttons that take you to sites -- this
button lists your Public and Local IP addresses -- lists the public IP twice -- so you can then compare if your Public IP is matching
that of https://dnsleaktest.com and or https://ipleak.net - the recommended site on the app is https://dnsleaktest.com

# How to use Information Gatherer?
Button "Check if IP Matched What's My IP" - This button gatherers your Public IP and Local IP but outputs your Public IP twice in the app its called "Double Check of Public IP". The methods for both Public IP checks are different.

Button "DNS Leak Test Recommended" - This button takes you to https://dnsleaktest.com and this site tests your DNS servers through a "Standard" and a "Extended" option Extended is Recommended. If this is showing anything related to your ISP you either do not have a VPN or your VPN is leaking DNS/IP results

Button "IP Leak Test" - This is basically what the above is but is not quite as "easy" for everyone. This site is preferred over DNS Leak Test for some but DNS Leak Test is preferred by others.

Button "What's My IP" - This button takes you to https://www.whatsmyip.org/ which basically tells you everything related to your IP, Ports, Traceroute, ETC. This site gives detailed results and is definitely a useful site for checking out whatever it is you need to check out. It is better to use something like https://dnsleaktest.com for DNS results though.

Button "What's My IP If IPv6" - This button takes you to https://whatismyipaddress.com/ which will give you results on your IP if you have IPv6. This site is not a site I would use especially since VPNs always give IPv4 over IPv6 but if by the off chance you have a IPv6 this site will give you a IPv4 and IPv6 result.

There is also a What's a DNS Leak and Help button - these buttons are basically for those who do not know what a DNS leak is or why IPs are important to protect. These buttons do not really need any explanation.

# Other
There is also a "Settings" button to allow the user to have some settings and also in those settings there is a Light Mode for you pesky
users out there.

There is also a Ping Test on the app - it is automatic.
It updates every second and it pings to https://speedtest.net - it was the best results out of the various sites I tested.
The Ping will not work if you have no internet -- app will warn you on startup if Interface is not connected -- but will automatically
start when you regain that connection.

# Images
![GitHub Logo](/images/Screenshot_1.png)
![GitHub Logo](/images/Screenshot_2.png)
