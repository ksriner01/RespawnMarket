# RespawnMarket

I created this WebApp project for this class on my own.

I propose to create a video game themed reseller marketplace where people can go to specifically sell their games or gaming computer parts to others who may be looking for a good deal. The name of this reseller marketplace application would be RespawnMarket as respawning is a mechanic in many games where a character comes back to life and this marketplace would allow people to give their parts and games life once more in the hands of someone else.

Code used was referenced from:
- Dykstra tutorials found here: https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-7.0&tabs=visual-studio
- Adam Freeman's book: Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages (2022)

For the final WebApp5 submission I solely used the code from Adam Freeman's SportsStore example in the book and altered it to fit my storepage, RespawnMarket.

The Administrator accounts can be viewed using an admin account by adding "/admin/identityusers/" to the end of the localhost URL and the admin account can be accessed by adding "/account/admin" to the end of the URL to which you will be prompted for a username and password which are:
- User: Admin
- Password: Secret123$

!!! IMPORTANT !!!
For the WebApp5 Submission procedure for downloading, preparing, and running the web application because I have two DbContexts they must both be updated individually by typing "Update-Database -Context StoreDbContext" and "Update-Database -Context AppIdentityDbContext" respectively. 

Newly Added in WebApp5 submission:
- Comments for all class, Razor Views, and Razor components in the RespawnMarket solution.
- Data annotations for the Order and Product Models.
- Authorization security.

Current warnings in the program:
- Warnings will appear when building for nullable types.
- Some inconsistent line ending errors may appear when running the program.
