# AspNetCoreHtmlToPdf

Generate PDF from HTML using wkhtmltopdf 

## wkhtmltopdf

It's a C++ Open Source Library (LGPLv3) [wkhtmltopdf](https://github.com/wkhtmltopdf/wkhtmltopdf). 

wkhtmltopdf and wkhtmltoimage are command line tools to render HTML into PDF and various image formats using the Qt WebKit rendering engine. These run entirely "headless" and do not require a display or display service.

There is wrapper for .Net Core written by fpanaccia [wkhtmltopdf.NetCore](https://github.com/fpanaccia/Wkhtmltopdf.NetCore)

## Step to setup the sample project

* Create a dot net core web api project 

	`dotnet new webapi -o HtmlToPdf.Wkhtmltopdf.Core`
	
* Change directories (cd) to the folder that will contain the project folder.

* Install the package WkhtmltoPdf.core

	`dotnet add package Wkhtmltopdf.NetCore --version 2.0.1`
	
* Copy 'Rotativa' folder which holds the executable of wkhtmltopdf library. 

	> Source Code: The folder has to be copied to the working folder 
	
	```
	
		    └── Rotativa
		    |   ├── Linux
		    |   |   └── wkhtmltopdf
		    |   ├── Mac
		    |   |   └── wkhtmltopdf
		    |   └── Windows
		    |       └── wkhtmltopdf.exe
	
	```
	
	> Build: The folder sometimes won't get copied to Release folder, in that case copy it manually. 
	
* Configure the library in Startup.cs file

	```
	        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddWkhtmltopdf();
        }
	```

* Build and Run the project 

* Access the URL [localhost:5002/api/HtmlToPdf/Get]