namespace file_based_router.approutes;

using System.Collections.Generic;


public class _content_
{
    public static (string?, IDictionary<string, IDictionary<string, string>>) GetContent()
        {
            IDictionary<string, IDictionary<string, string>> cityData =
                new Dictionary<string, IDictionary<string, string>>()
                {
                    {
                        "Gotham", new Dictionary<string, string>()
                        {
                            { "Nome", "Gotham City" },
                            { "Número de Habitantes", "10 milhões" },
                            { "Super-Herói", "Batman" },
                            {
                                "Description",
                                "Gotham City é uma cidade fictícia conhecida por ser a residência de Batman."
                            },
                            {
                                "VillainDescription",
                                "Gotham is infamous for its high crime rate and numerous villains such as The Joker, The Penguin, and The Riddler. These characters have become iconic in popular culture."
                            }
                        }
                    },
                    {
                        "Metropolis", new Dictionary<string, string>()
                        {
                            { "Nome", "Metropolis" },
                            { "Número de Habitantes", "8 milhões" },
                            { "Super-Herói", "Superman" },
                            {
                                "Description",
                                "Metropolis é uma cidade fictícia conhecida por ser a residência de Superman."
                            }
                        }
                    }
                };

            string? htmlContent = @"<!DOCTYPE html>
            <html lang=""en"">
            <head>
                <meta charset=""UTF-8"">
                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                <title>[:Nome]</title>
                <style>
                    body {
                        font-family: 'Arial', sans-serif;
                        margin: 0;
                        padding: 0;
                        background-color: #2c3e50;
                        color: #ecf0f1;
                    }
                    header {
                        background-color: #34495e;
                        padding: 1em 0;
                        text-align: center;
                        box-shadow: 0 4px 2px -2px gray;
                    }
                    header h1 {
                        margin: 0;
                        font-size: 2.5em;
                        color: #ecf0f1;
                    }
                    nav {
                        text-align: center;
                        background-color: #2c3e50;
                        padding: 0.5em 0;
                    }
                    nav a {
                        color: #ecf0f1;
                        margin: 0 15px;
                        text-decoration: none;
                        font-size: 1.2em;
                    }
                    nav a:hover {
                        color: #e74c3c;
                    }
                    .container {
                        width: 80%;
                        margin: 2em auto;
                        padding: 1em;
                        background-color: #34495e;
                        border-radius: 8px;
                        box-shadow: 0 4px 8px rgba(0,0,0,0.2);
                    }
                    h2 {
                        text-align: center;
                        color: #e74c3c;
                    }
                    p {
                        line-height: 1.6;
                        margin: 1em 0;
                        font-size: 1.1em;
                    }
                    .image-container {
                        text-align: center;
                    }
                    .image-container img {
                        width: 100%;
                        max-width: 600px;
                        border-radius: 8px;
                        box-shadow: 0 4px 8px rgba(0,0,0,0.2);
                    }
                    .footer {
                        text-align: center;
                        padding: 1em 0;
                        background-color: #34495e;
                        color: #ecf0f1;
                        position: relative;
                        bottom: 0;
                        width: 100%;
                        box-shadow: 0 -4px 2px -2px gray;
                    }
                </style>
            </head>
            <body>
                <header>
                    <h1>[:Nome]</h1>
                </header>
                <nav>
                    <a href=""#history"">History</a>
                    <a href=""#villains"">Villains</a>
                    <a href=""#architecture"">Architecture</a>
                </nav>
                <div class=""container"">
                    <section id=""history"">
                        <h2>History of [:Nome]</h2>
                        <p>[:Description]</p>
                    </section>
                    <section id=""villains"">
                        <h2>Infamous Villains</h2>
                        <p>[:VillainDescription]</p>
                    </section>
                    <section id=""architecture"">
                        <h2>Architecture</h2>
                        <p></p>
                    </section>
                </div>
                <div class=""footer"">
                    <p>&copy; 2024 [:Nome] Information. All rights reserved.</p>
                </div>
            </body>
            </html>
        ";
            
            return (htmlContent, cityData);
        }
}