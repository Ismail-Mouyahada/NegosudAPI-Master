

 ![logo-negosud](https://user-images.githubusercontent.com/66369128/220627476-59a06d7c-398f-4a77-80b8-3e9ad7555c9a.png)

- Modelisation conceptuelle de données (MCD) :  [MCD-negosud-cube](https://drawsql.app/teams/access-energies/diagrams/negosuddb)

- Documentation complete de l'API : [Documentation-complet-api-negosud-cube](https://unexpected-salt-c05.notion.site/Documentation-de-l-API-Negosud-ASP-net-Core-7-45857da0a78a40adb691b77005d5fe18)
# Negosud REST API 
API devloped by Ismail Mouyahada for educational purposes.

link to the API : http://195.154.113.18:8000/swagger/index.html

# Installation des dépendances et déploiement de l'API Negosud

Pour installer les dépendances de l'API Negosud créée en [ASP.NET](http://asp.net/) Core, vous devez tout d'abord vous assurer d'avoir installé .NET Core SDK sur votre machine. Vous pouvez le télécharger à partir du site officiel de Microsoft.

Une fois que .NET Core SDK est installé, vous pouvez ouvrir un terminal ou une invite de commande et exécuter la commande suivante pour installer les dépendances :

```
dotnet restore

```

Cette commande téléchargera toutes les dépendances du projet et les installera sur votre machine.

Ensuite, vous devrez procéder aux migrations de base de données en utilisant la commande suivante :

```
dotnet ef database update

```

Cette commande créera la base de données pour votre API et mettra à jour le schéma de la base de données.

Enfin, pour déployer votre API Negosud, vous pouvez utiliser une plateforme de déploiement en ligne telle que Azure ou AWS. Vous pouvez également déployer l'API sur un serveur dédié en suivant les instructions de déploiement [ASP.NET](http://asp.net/) Core.

En suivant ces étapes, vous serez en mesure d'installer les dépendances de l'API, effectuer les migrations de base de données et déployer l'API Negosud créée en [ASP.NET](http://asp.net/) Core.

Si vous souhaitez déployer votre API sur un serveur dédié, vous pouvez suivre les étapes suivantes :

1. Compilez le projet en utilisant la commande suivante :

```
dotnet publish -c Release

```

Cette commande compilera le projet et créera une version optimisée pour la production dans le dossier `bin/Release/netcoreapp[version]/publish`.

1. Transférez les fichiers de l'API sur le serveur en utilisant un outil de transfert de fichiers tel que FileZilla.
2. Installez .NET Core Runtime sur le serveur si ce n'est pas déjà fait. Vous pouvez le télécharger à partir du site officiel de Microsoft.
3. Exécutez l'application en utilisant la commande suivante :

```
dotnet [nom de l'API].dll

```

Remplacez `[nom de l'API]` par le nom de votre application.

En suivant ces étapes, vous pourrez déployer votre API Negosud sur un serveur dédié.

N'hésitez pas à me faire part de vos commentaires ou de vos questions si vous avez besoin d'aide supplémentaire.
