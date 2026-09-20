var builder = DistributedApplication.CreateBuilder(args);

var mysql = builder.AddMySql("mysql")
    .WithLifetime(ContainerLifetime.Persistent)
    .WithDataVolume(isReadOnly: false);

var mysqldb = mysql.AddDatabase("mysqldb");

builder.AddContainer("phpmyadmin", "phpmyadmin/phpmyadmin")
    .WithHttpEndpoint(targetPort: 80)
    .WithVolume("phpmyadmin_data", "/var/www/html/themes")
    .WithEnvironment("PMA_HOST", mysql.Resource.Name)          // nom du conteneur MySQL (résolu via le réseau Aspire)
    .WithEnvironment("PMA_USER", "root")
    .WithEnvironment("PMA_PASSWORD", mysql.Resource.PasswordParameter) // mot de passe généré par Aspire
    .WaitFor(mysql);


var apiService = builder.AddProject<Projects.GameNotationApp_ApiService>("apiservice")
    .WithHttpHealthCheck("/health")
    .WithReference(mysqldb)
    .WaitFor(mysqldb);

builder.AddProject<Projects.GameNotationApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();