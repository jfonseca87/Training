using BookService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BookService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICRUDService" in both code and config file together.
    [ServiceContract]
    public interface ICRUDService
    {

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat=WebMessageFormat.Json, UriTemplate="getbooks")]
        List<Book> listBook();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat=WebMessageFormat.Json, UriTemplate="getbook/{id}")]
        Book getBook(string id);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat=WebMessageFormat.Json, UriTemplate="newbook")]
        bool newBook(Book book);

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "editbook")]
        bool editBook(Book book);

        [OperationContract]
        [WebInvoke(Method = "POST", BodyStyle=WebMessageBodyStyle.Wrapped, ResponseFormat=WebMessageFormat.Json, UriTemplate="delbook")]
        bool deleteBook(string id);
    }
}
