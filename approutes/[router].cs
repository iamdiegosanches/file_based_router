namespace file_based_router.approutes;

public class _router_
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
                                              <li><a class="nav-link" href="/content/article1">Content Mapping Article 1</a></li>
                                              <li><a class="nav-link" href="/content/article2">Content Mapping Article 2</a></li>
                                            </ul>
                                          </nav>
                                          <main id="main-doc">
                                            <section class="main-section" id="Introduction">
                                              <header>How It Works</header>
                                              <article>
                                                The program works by dynamically mapping HTTP requests to specific files on the server based on the URL path.
                                                <ol>
                                                  <li>Receive Request: When a request is made to the web server, the router captures the URL path.
                                                  </li>
                                                    <li>Determine File: The router analyzes the URL path to determine which file corresponds to the request. For example, a request to /user/profile would map to a file like user/profile.cs.
                                                  </li>
                                                    <li>Check File Existence: The router checks if the file exists on the server. If not, it returns a 404 error.
                                                  </li>
                                                    <li>Compile and Execute File: If the file exists, the router reads its contents, compiles the C# code, and executes a predefined method within the file (e.g., GetContent).
                                                  </li>
                                                    <li>Generate Response: The executed method generates HTML content or other responses based on the logic defined in the file. This content is then returned as the HTTP response to the client.
                                                  </li>
                                                    <li>Dynamic Content Handling: The router can also handle dynamic content replacement. If the file’s GetContent method returns a tuple containing HTML and data, the router processes the HTML by replacing placeholders with actual data values before sending the response.
                                                  </li>
                                                </ol>
                                              </article>
                                            </section>
                                          </main>
                                  """;
            
            return htmlContent;
        }
}