# Apiwadokan

<h2 align="center"> KARATE WADOKAN-BACK</h2>


<div align="center"><img src="https://user-images.githubusercontent.com/117834971/234863466-30d1ee0e-06ad-441e-a420-16d52a7a7b3c.png" width=250></div>





<h2 align="justify"> 📝Project description:</h2>
<p align="justify">This pedagogical project was created as a final presentation of the full stack bootcamp of Factoria F5 and Fundación Don Bosco-Sevilla. The goal is to create a website for a real client: Karate Wadokan. Our team created a desktop and responsive website, where the client can publish and change their schedules and class calendar by center/class, upload images, edit and delete these images, edit texts and manage documents sent by students.</p>

<h2 align="justify"> 🔧Stacks:</h2>
<p align="justify">| Node.js | NPM | React |JavaScript | CSS3 | HTML5 | C# | ASP.NET Core 6 | Entity Framework 7 | SQL Server| Tailwind CSS |</p>


<h2 align="justify"> :computer: How to install the project (Back) </h2>
<p align="justify> This section demonstrates how to set up your own local database and how to connect it to the API we developed specifically for Wadokan Front project to use. 
It must be noted that, even though the Wadokan Front project may be run using json-server, it is highly recommended to set it up using Apiwadokan Back project.   </h3> 
<p> </p> 

<h3 align="justify"> Recommended installation steps </h3> 

1. Clone repository (preferably next to Wadokan Front repository, we go hand in hand)  </p> 

2. Create your own local database in Microsoft SQL Server Management Studio </p> 

3. Connect your new database to Apiwadokan project accessing _appsettings.json_ file </p> 
4. Run *add-migration _name_ -Project Data* 
                  
5. Run *update-database*                 

6. Check the connection is active in the Server Explorer </p> 

7. All set! Build Apiwasokan -Back solution and run _npm run dev_ command in wadokan front project </p> 

> While connecting the project to your database, note that your *Data source=...* and *initial catalog=...* corresponds to the name of your computer and the name of your database respectively.  

<h2 align="justify"> :mag: In depth </h2> 

<p align="justify"> Here you can find more information about the built-in entities and methods in 1.0 version of Apiwadokan back project. </p> 


| Entities    | Methods         |
| ------------|:---------------:| 
|             | GetAll          | 
|             | Add/Insert/Post |   
| File        | Update/Patch    |   
|             | Deactivate      |    
|             | Delete          |   
|             | GetById         | 
|             | GetByCriteria   |

> Note that not every entity has all built-in methods in this 1.0 version, but may be implemented in future versions according to the clients' needs. 
                  
<h2 align="justify"> 👀  Testing: Back</h2>
<p align="justify">- Tested Event Service - Validate Model  </p> 
<p align="justify">- Tested User Entity/Encrypted Password </p> 
<p align="justify">- Tested User Item Constructor Is Active </p>

<h2 align="justify">  🧪Next Steps:</h2>

















## 👩‍💻Group members:
+ 
|<img src="https://user-images.githubusercontent.com/117834971/234281071-f3f6a329-276a-4e1d-839a-81750cb040be.png" width=115><p>Scrum Master</p><h5><a href="https://github.com/MartaMunMol">Marta Muñoz</a></h5><h5><a href="https://www.linkedin.com/in/marta-m-28b334257//">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834971/234281032-b739b505-7c23-4a6d-b744-361b033a16b9.png" width=115><p>Product Owner</p><h5><a href="https://github.com/MeryGF">María Gimenéz</a></h5><h5><a href="https://www.linkedIn.com/in/margimfig/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834971/234281295-c035f658-2cd6-4f3d-a453-5b13d3a73a0a.png" width=130><p>Developer</p><h5><a href="https://github.com/Ma-shi22">Maria Carvalho</a></h5><h5><a href="https://www.linkedin.com/in/mariashirleicarvalho/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834971/234281127-87812517-4b78-42b1-a3dd-0adeeae2529e.png" width=120><p>Developer</p><h5><a href="https://github.com/Carmen-Trillo/">Carmen Trillo</a></h5><h5><a href="https://www.linkedin.com/in/carmentrillonavarro/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834971/234281100-a4e510b1-bbb1-4141-aaa8-95f3ff878a48.png" width=115><p>Developer</p><h5><a href="https://github.com/Milacover">Yamila Marquez</a></h5><h5><a href="https://www.linkedin.com/in/yamila-marquez-lobato-640244199/">LinkedIn</a></h5>|
| :---: | :---: | :---: | :---: | :---: |
