# RespawnMarket

I created the WebApp project for this class on my own.

I propose to create a video game themed reseller marketplace where people can go to specifically sell their games or gaming computer parts to others who may be looking for a good deal. The name of this reseller marketplace application would be RespawnMarket as respawning is a mechanic in many games where a character comes back to life and this marketplace would allow people to give their parts and games life once more in the hands of someone else.

Code used was referenced from:
- Dykstra tutorials found here: https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studio
- Adam Freeman's book: Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages (2022)

However for the WebApp3 and WebApp4 submissions I solely used the code from Adam Freeman's SportsStore example in the book and altered it to fit my storepage, RespawnMarket.

The Administrator account can be accessed by adding "/account/admin" to the end of the URL to which you will be prompted for a username and password which are:
User: Admin
Password: Secret123$

Newly Added in WebApp4 submission:
- CRUD features for products database as an administrator.
- Second and third DbSet<> entities for orders and accounts.
- Fully operational shopping cart and checkout systems.
- Side bar for navigating (filtering) between the categories of items.
- Administration functionality that is accessed by logging into the admin account.
- Security authorization so that only admins may access the admin page.
- Some aethestic updates to the html code.

Current warnings in the program:
- Warnings will appear when building for nullable types.

To be added:
- Comments for all pages in the program.
