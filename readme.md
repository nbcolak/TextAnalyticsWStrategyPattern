
Bu proje, Strategy Pattern kullanarak iki farklı analiz sağlayıcısıyla duygusal analiz gerçekleştirmektedir: Azure Cognitive Services ve Google Cloud Natural Language API. Kullanıcı, analiz sağlayıcısını belirleyerek (Google veya Azure), metin üzerinde duygusal analiz yapabilir. Proje aynı zamanda Dependency Injection (DI) ile esnek bir yapı sunar ve yapılandırma ayarlarını appsettings.json üzerinden yönetir.

Kullanım

	1.	Proje yapılandırma ayarlarında, Google veya Azure API bilgilerinizi appsettings.json dosyasına ekleyin.
	2.	HTTP isteklerinde provider (Google veya Azure) belirtin.
	3.	Metin göndererek duygusal analiz sonuçlarını alın.

Emotional Analysis with Strategy Pattern (Using Azure and Google AI)

This project performs emotional analysis using the Strategy Pattern with two different analysis providers: Azure Cognitive Services and Google Cloud Natural Language API. The user can choose the analysis provider (Google or Azure) and perform emotional analysis on the text. The project also provides a flexible structure with Dependency Injection (DI) and manages configuration settings through the appsettings.json file.

Usage

	1.	Add your Google or Azure API credentials to the appsettings.json file in the project configuration.
	2.	Specify the provider (Google or Azure) in the HTTP requests.
	3.	Submit the text to receive the emotional analysis results.

Análisis Emocional con el Patrón de Estrategia (usando Azure y Google AI)

Este proyecto realiza un análisis emocional utilizando el Patrón de Estrategia con dos proveedores de análisis diferentes: Azure Cognitive Services y Google Cloud Natural Language API. El usuario puede elegir el proveedor de análisis (Google o Azure) y realizar un análisis emocional en el texto. El proyecto también ofrece una estructura flexible con Inyección de Dependencias (DI) y gestiona la configuración a través del archivo appsettings.json.

Uso

	1.	Agregue sus credenciales de API de Google o Azure al archivo appsettings.json en la configuración del proyecto.
	2.	Especifique el provider (Google o Azure) en las solicitudes HTTP.
	3.	Envíe el texto para recibir los resultados del análisis emocional.

Emotionale Analyse mit dem Strategie-Muster (unter Verwendung von Azure und Google AI)

Dieses Projekt führt eine emotionale Analyse mit dem Strategie-Muster und zwei verschiedenen Analyseanbietern durch: Azure Cognitive Services und Google Cloud Natural Language API. Der Benutzer kann den Analyseanbieter (Google oder Azure) wählen und eine emotionale Analyse des Textes durchführen. Das Projekt bietet auch eine flexible Struktur mit Dependency Injection (DI) und verwaltet die Konfigurationseinstellungen über die appsettings.json-Datei.

Verwendung

	1.	Fügen Sie Ihre Google- oder Azure-API-Anmeldeinformationen in die appsettings.json-Datei der Projektkonfiguration ein.
	2.	Geben Sie den provider (Google oder Azure) in den HTTP-Anfragen an.
	3.	Senden Sie den Text, um die Ergebnisse der emotionalen Analyse zu erhalten.s