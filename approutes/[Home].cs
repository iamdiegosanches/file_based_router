namespace file_based_router.approutes;

public class _Home_
{
    public static string? GetContent()
    {

        string? htmlContent = """
                              <!DOCTYPE html>
                                          <html lang="en">
                                          <head>
                                              <meta charset="UTF-8">
                                              <meta name="viewport" content="width=device-width, initial-scale=1.0">
                                              <title>Home</title>
                                              <style>
                                                  html,
                                                  body {
                                                    min-width: 290px;
                                                    color: #e7e7e7;
                                                    background-color: #313131;
                                                    font-family: 'Open Sans', Arial, sans-serif;
                                                    line-height: 1.5;
                                                  }
                              
                                                  #navbar {
                                                    position: fixed;
                                                    min-width: 290px;
                                                    top: 0px;
                                                    left: 0px;
                                                    width: 300px;
                                                    height: 100%;
                                                    border-right: solid;
                                                    border-color: #e7e7e7;
                                                  }
                              
                                                  img {
                                                    display: block;
                                                    margin: 0 auto;
                                                    height: 200px;
                                                  }
                              
                                                  header {
                                                    color: #e7e7e7;
                                                    margin: 10px;
                                                    text-align: center;
                                                    font-size: 1.8em;
                                                    font-weight: thin;
                                                  }
                              
                                                  #main-doc header {
                                                    text-align: left;
                                                    margin: 0px;
                                                  }
                              
                                                  #navbar ul {
                                                    height: 88%;
                                                    padding: 0;
                                                    overflow-y: auto;
                                                    overflow-x: hidden;
                                                  }
                              
                                                  #navbar li {
                                                    color: #e7e7e7;
                                                    border-top: 2px solid;
                                                    list-style: none;
                                                    position: relative;
                                                    width: 100%;
                                                  }
                              
                                                  #navbar a {
                                                    display: block;
                                                    padding: 10px 30px;
                                                    color: #e7e7e7;
                                                    text-decoration: none;
                                                    cursor: pointer;
                                                  }
                              
                                                  #main-doc {
                                                    position: absolute;
                                                    margin-left: 310px;
                                                    padding: 20px;
                                                    margin-bottom: 110px;
                                                  }
                              
                                                  section article {
                                                    color: #e7e7e7;
                                                    margin: 15px;
                                                    font-size: 0.96em;
                                                  }
                              
                                                  section li {
                                                    margin: 15px 0px 0px 20px;
                                                  }
                              
                                                  code {
                                                    display: block;
                                                    text-align: left;
                                                    white-space: pre-line;
                                                    position: relative;
                                                    word-break: normal;
                                                    word-wrap: normal;
                                                    line-height: 2;
                                                    background-color: #111111;
                                                    padding: 15px;
                                                    margin: 10px;
                                                    border-radius: 5px;
                                                  }
                              
                                                  @media only screen and (max-width: 815px) {
                                                    /* For mobile phones: */
                                                    #navbar ul {
                                                      border: 1px solid;
                                                      height: 207px;
                                                    }
                              
                                                    #navbar {
                                                      background-color: #313131;;
                                                      position: absolute;
                                                      top: 0;
                                                      padding: 0;
                                                      margin: 0;
                                                      width: 100%;
                                                      max-height: 275px;
                                                      border: none;
                                                      z-index: 1;
                                                      border-bottom: 2px solid;
                                                    }
                              
                                                    #main-doc {
                                                      position: relative;
                                                      margin-left: 0px;
                                                      margin-top: 270px;
                                                    }
                              
                                                    img {
                                                      display: block;
                                                      margin: 0 auto;
                                                      height: 150px;
                                                    }
                                                  }
                              
                                                  .reference{
                                                      color: #ffff00;
                                                  }
                              
                                                  .reference:visited {
                                                      color: #baba00;
                                                  }
                              
                                                  @media only screen and (max-width: 400px) {
                                                    #main-doc {
                                                      margin-left: -10px;
                                                    }
                              
                                                    code {
                                                      margin-left: -20px;
                                                      width: 100%;
                                                      padding: 15px;
                                                      padding-left: 10px;
                                                      padding-right: 45px;
                                                      min-width: 233px;
                                                    }
                                                  }
                                              </style>
                                          </head>
                                          <nav id="navbar">
                                        <header style="color: #ffff00;">The File Based Router</header>
                                        <ul>
                                          <li><a class="nav-link" href="/router">How It Works?</a></li>
                                        </ul>
                                      </nav>
                                      <main id="main-doc">
                                        <section class="main-section" id="Introduction">
                                          <header>Introduction</header>
                                          <article>
                                            <p>
                                            A file-based router is a type of web application router that dynamically maps HTTP requests to file-based handlers. In a typical file-based routing system, each URL pattern is associated with a specific file on the server, and the contents of these files determine the application's response. This approach is commonly used to organize code in a manner that directly mirrors the structure of the URL paths.
                                            <br/>
                                            Key benefits of file-based routing include:
                                            <ul>
                                            <li>Intuitive Organization: The directory and file structure directly represent the URL structure, making it easier to navigate and manage the codebase.
                                            </li>
                                            <li>Scalability: As the application grows, new routes can be added by simply creating new files, without modifying a central routing configuration.
                                            </li>
                                            <li>Simplicity: Routing logic is simplified because the framework automatically handles the mapping of requests to files based on the URL pattern.
                                            </li>
                                            </ul>
                                            </p>
                                          </article>
                                        </section>
                                      </main>
                              """;
        return htmlContent;
    }
}