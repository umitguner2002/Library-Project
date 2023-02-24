using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace LibraryProject
{
    internal class MYDB
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-12FASN2\\SQLEXPRESS;" +
        "Initial Catalog=Library;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        MYMSG msg = new MYMSG();

        private void dbOpen()
        {
            conn.Open();
        }

        private void dbClose()
        {
            conn.Close();
        }

        
        //
        // GENRES DATABASE OPERATIONS
        //
        // GENRE ADD
        public void AddGenre(String newValue)
        {
            try
            {
                if (!newValue.Trim().Equals(""))
                {
                    if (GenreDataIsUnique(newValue))
                    {
                        dbOpen();
                        cmd = new SqlCommand("INSERT INTO Genres(genreName) VALUES (@genreName)", conn);
                        cmd.Parameters.AddWithValue("@genreName", newValue.Trim());
                        cmd.ExecuteNonQuery();
                        dbClose();
                        msg.AddMessage();
                    }
                    else
                        msg.ItemExist();
                }
                else
                    msg.EmptyItem("Genre Name");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }             
        }

        //
        // GENRE EDIT
        public void EditGenre(int genreID, String newValue)
        {
            try
            {
                if (!newValue.Trim().Equals(""))
                {
                    if (GenreDataIsUnique(newValue))
                    {
                        dbOpen();
                        cmd = new SqlCommand("UPDATE Genres SET genreName=@genreName WHERE genreID=" + genreID, conn);
                        cmd.Parameters.AddWithValue("@genreName", newValue.Trim());
                        cmd.ExecuteNonQuery();
                        dbClose();
                        msg.EditMessage();
                    }
                    else
                        msg.ItemExist();
                }
                else
                    msg.EmptyItem("Genre Name");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //
        // GENRE DELETE
        public int DeleteGenre(int genreID)
        {
            try
            {
                if (msg.ConfirmDeleteMessage() == DialogResult.Yes)
                {
                    dbOpen();
                    cmd = new SqlCommand("DELETE FROM Genres WHERE genreID=" + genreID, conn);
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.DeleteMessage();
                    return 1;
                }
                else
                    return 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return 0;
            }
        }

        //
        //GENRE LIST
        public DataTable GenreList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT * FROM Genres ORDER BY genreName", conn);                
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        // GENRE DATA UNIQUE CONTROL
        public bool GenreDataIsUnique(String genreName)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(genreName) FROM Genres WHERE genreName='" + genreName + "'", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                if (count != 0)
                    return false;
                else
                    return true;                    
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        // GENRE DATA COUNT
        public int GenreDataCount()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(genreID) FROM Genres", conn);
                int dataCount = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                return dataCount;
            }
            catch (Exception)
            {
                return 0;
            }            
        }

        //
        // GENRE DATA SEARCH
        public DataTable GenreDataSearch(String value)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT * FROM Genres WHERE genreName LIKE '" + value + "%' ORDER BY genreName", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        //GENRE LIST FOR EXCEL
        public DataTable GenreExcelList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT * FROM Genres ORDER BY genreID", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }



        //
        // AUTHOR DATABASE OPERATIONS
        //
        // AUTHOR ADD
        public void AddAuthor(String authorName, String authorCountry)
        {
            try
            {
                if (!authorName.Trim().Equals(""))
                {
                    if (AuthorDataIsUnique(authorName))
                    {
                        dbOpen();
                        cmd = new SqlCommand("INSERT INTO Authors VALUES (@authorName, @authorCountry)", conn);
                        cmd.Parameters.AddWithValue("@authorName", authorName.Trim());
                        cmd.Parameters.AddWithValue("@authorCountry", authorCountry.Trim());
                        cmd.ExecuteNonQuery();
                        dbClose();
                        msg.AddMessage();
                    }
                    else
                        msg.ItemExist();
                }
                else
                    msg.EmptyItem("Author Name");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //
        // AUTHOR EDIT
        public void EditAuthor(int authorID, String authorName, String authorCountry)
        {
            try
            {
                if (!authorName.Trim().Equals(""))
                {
                    if (AuthorDataIsUnique(authorName))
                    {
                        dbOpen();
                        cmd = new SqlCommand("UPDATE Authors SET authorName=@authorName, authorCountry=@authorCountry WHERE authorID=" + authorID, conn);
                        cmd.Parameters.AddWithValue("@authorName", authorName.Trim());
                        cmd.Parameters.AddWithValue("@authorCountry", authorCountry.Trim());
                        cmd.ExecuteNonQuery();
                        dbClose();
                        msg.EditMessage();
                    }
                    else
                        msg.ItemExist();
                }
                else
                    msg.EmptyItem("Author Name");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //
        // AUTHOR DELETE
        public int DeleteAuthor(int authorID)
        {
            try
            {
                if (msg.ConfirmDeleteMessage() == DialogResult.Yes)
                {
                    dbOpen();
                    cmd = new SqlCommand("DELETE FROM Authors WHERE authorID=" + authorID, conn);
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.DeleteMessage();
                    return 1;
                }
                else
                    return 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return 0;
            }
        }

        //
        //AUTHOR LIST
        public DataTable AuthorList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT * FROM Authors ORDER BY authorName", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        // AUTHOR DATA UNIQUE CONTROL
        public bool AuthorDataIsUnique(String authorName)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(authorName) FROM Authors WHERE authorName='" + authorName + "'", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                if (count != 0)
                    return false;
                else
                    return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        // AUTHOR DATA SEARCH
        public DataTable AuthorDataSearch(String value)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT * FROM Authors WHERE authorName LIKE '" + value + "%' ORDER BY authorName", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        // AUTHOR DATA COUNT
        public int AuthorDataCount()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(authorID) FROM Authors", conn);
                int dataCount = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                return dataCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //
        //AUTHOR LIST FOR EXCEL
        public DataTable AuthorExcelList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT * FROM Authors ORDER BY authorID", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }


        //
        // PUBLISHERS DATABASE OPERATIONS
        //
        // PUBLISHER ADD
        public void AddPublisher(String newValue)
        {
            try
            {
                if (!newValue.Trim().Equals(""))
                {
                    if (PublisherDataIsUnique(newValue))
                    {
                        dbOpen();
                        using (new SqlCommand())
                        {
                            cmd.CommandText = "INSERT INTO Publishers(publisherName) VALUES (@publisherName)";
                            cmd.Parameters.AddWithValue("@publisherName", newValue.Trim());
                            cmd.ExecuteNonQuery();
                            dbClose();
                            msg.AddMessage();
                        }                        
                    }
                    else
                        msg.ItemExist();
                }
                else
                    msg.EmptyItem("Publisher");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //
        // PUBLISHER EDIT
        public void EditPublisher(int publisherID, String newValue)
        {
            try
            {
                if (!newValue.Trim().Equals(""))
                {
                    if (PublisherDataIsUnique(newValue))
                    {
                        dbOpen();
                        cmd = new SqlCommand("UPDATE Publishers SET publisherName=@publisherName WHERE publisherID=" + publisherID, conn);
                        cmd.Parameters.AddWithValue("@publisherName", newValue.Trim());
                        cmd.ExecuteNonQuery();
                        dbClose();
                        msg.EditMessage();
                    }
                    else
                        msg.ItemExist();
                }
                else
                    msg.EmptyItem("Publisher");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //
        // PUBLISHER DELETE
        public int DeletePublisher(int publisherID)
        {
            try
            {
                if (msg.ConfirmDeleteMessage() == DialogResult.Yes)
                {
                    dbOpen();
                    cmd = new SqlCommand("DELETE FROM Publishers WHERE publisherID=" + publisherID, conn);
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.DeleteMessage();
                    return 1;
                }
                else
                    return 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return 0;
            }
        }

        //
        //PUBLISHER LIST
        public DataTable PublisherList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT * FROM Publishers ORDER BY publisherName", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        // PUBLISHER DATA UNIQUE CONTROL
        public bool PublisherDataIsUnique(String publisherName)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(publisherName) FROM Publishers WHERE publisherName='" + publisherName + "'", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                 if (count != 0)
                    return false;
                else
                    return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        // PUBLISHER DATA COUNT
        public int PublisherDataCount()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(publisherID) FROM Publishers", conn);
                int dataCount = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                return dataCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //
        // PUBLISHER DATA SEARCH
        public DataTable PublisherDataSearch(String value)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT * FROM Publishers WHERE publisherName LIKE '" + value + "%' ORDER BY publisherName", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        //PUBLISHER LIST FOR EXCEL
        public DataTable PublisherExcelList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT * FROM Publishers ORDER BY publisherID", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }


        //
        // MEMBERS DATABASE OPERATIONS
        //
        // MEMBER ADD
        public bool AddMember(String TCNo, String name, String surname, String gender, DateTime birthDate, 
            String phone, String email, String address)
        {
            try
            {
                if (!TCNo.Trim().Equals(""))
                {
                    if (MemberDataIsUnique(TCNo))
                    {
                        dbOpen();
                        cmd = new SqlCommand("INSERT INTO Members(memberTCNo, memberName, memberSurname, memberGender, memberBirthDate, memberPhone, memberEMail, memberAddress) VALUES (@TCNo, @Name, @Surname, @Gender, @BirthDate, @Phone, @EMail, @Address)", conn);
                        cmd.Parameters.AddWithValue("@TCNo", TCNo);
                        cmd.Parameters.AddWithValue("@Name", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.Trim()));
                        cmd.Parameters.AddWithValue("@Surname", surname.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@BirthDate", Convert.ToDateTime(birthDate.ToShortDateString()));
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@EMail", email.Trim());
                        cmd.Parameters.AddWithValue("@Address", address.Trim());
                        cmd.ExecuteNonQuery();
                        dbClose();
                        msg.AddMessage();
                        return true;
                    }
                    else
                    {
                        msg.ItemExist();
                        return false;
                    }    
                        
                }
                else
                {
                    msg.EmptyItem("T.C.No");
                    return false;
                } 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        // MEMBER EDIT
        public void EditMember(int memberID, String TCNo, String name, String surname, String gender, 
            DateTime birthDate, String phone, String email, String address)
        {
            try
            {
                if (!TCNo.Trim().Equals(""))
                {
                    dbOpen();
                    cmd = new SqlCommand("UPDATE Members SET memberTCNo=@TCNo, memberName=@Name, memberSurname=@Surname, memberGender=@Gender, memberBirthDate=@BirthDate, memberPhone=@Phone, memberEMail=@EMail, memberAddress=@Address WHERE memberID=" + memberID, conn);
                    cmd.Parameters.AddWithValue("@TCNo", TCNo);
                    cmd.Parameters.AddWithValue("@Name", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.Trim()));
                    cmd.Parameters.AddWithValue("@Surname", surname.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@BirthDate", Convert.ToDateTime(birthDate.ToShortDateString()));
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@EMail", email.Trim());
                    cmd.Parameters.AddWithValue("@Address", address.Trim());
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.EditMessage();
                }
                else
                    msg.EmptyItem("T.C.No");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //
        // MEMBER DELETE
        public int DeleteMember(int memberID)
        {
            try
            {
                if (msg.ConfirmDeleteMessage() == DialogResult.Yes)
                {
                    dbOpen();
                    cmd = new SqlCommand("DELETE FROM Members WHERE memberID=" + memberID, conn);
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.DeleteMessage();
                    return 1;
                }
                else
                    return 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return 0;
            }
        }

        //
        //MEMBER LIST
        public DataTable MemberList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT memberID, memberTCNo, memberName, memberSurname, memberGender, memberBirthDate, memberPhone, memberEMail, memberAddress, [memberName] + ' ' + [memberSurname] AS [name] FROM Members ORDER BY memberName", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        // MEMBER DATA UNIQUE CONTROL
        public bool MemberDataIsUnique(String TCNo)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(memberTCNo) FROM Members WHERE memberTCNo='" + TCNo + "'", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                if (count != 0)
                    return false;
                else
                    return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        // MEMBER DATA COUNT
        public int MemberDataCount()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(memberID) FROM Members", conn);
                int dataCount = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                return dataCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //
        // MEMBER DATA SEARCH T.C.No
        public DataTable MemberDataSearch(String value)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT memberID, memberTCNo, memberName, memberSurname, memberGender, memberBirthDate, memberPhone, memberEMail, memberAddress, [memberName] + ' ' + [memberSurname] AS [name] FROM Members WHERE memberTCNo='" + value + "'", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        // MEMBER DATA SEARCH memberID
        public DataTable MemberDataSearch(int value)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT memberID, memberTCNo, memberName, memberSurname, memberGender, memberBirthDate, memberPhone, memberEMail, memberAddress, [memberName] + ' ' + [memberSurname] AS [name] FROM Members WHERE memberID=" + value, conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        //MEMBER LIST FOR EXCEL
        public DataTable MemberExcelList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT memberID, memberTCNo, [memberName] + ' ' + [memberSurname] AS [name], memberGender, memberBirthDate, memberPhone, memberEMail, memberAddress FROM Members ORDER BY memberID", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }



        //
        // BOOKS DATABASE OPERATIONS
        //
        // BOOK ADD
        public bool AddBook(String isbn, String title, int pageCount, int authorID, int genreID, int publisherID, DateTime publishDate, int quantity)
        {
            try
            {
                if (!isbn.Trim().Equals(""))
                {
                    if (BookDataIsUnique(isbn))
                    {
                        dbOpen();
                        cmd = new SqlCommand("INSERT INTO Books VALUES (@isbn, @title, @pageCount, @authorID, @genreID, @publisherID, @publishDate, @quantity)", conn);
                        cmd.Parameters.AddWithValue("@isbn", isbn.Trim());
                        cmd.Parameters.AddWithValue("@title", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.Trim()));
                        cmd.Parameters.AddWithValue("@pageCount", pageCount);
                        cmd.Parameters.AddWithValue("@authorID", authorID);
                        cmd.Parameters.AddWithValue("@genreID", genreID);
                        cmd.Parameters.AddWithValue("@publisherID", publisherID);
                        cmd.Parameters.AddWithValue("@publishDate", Convert.ToDateTime(publishDate.ToShortDateString()));
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.ExecuteNonQuery();
                        dbClose();
                        msg.AddMessage();
                        return true;
                    }
                    else
                    {
                        msg.ItemExist();
                        return false;
                    }

                }
                else
                {
                    msg.EmptyItem("Book ISBN");
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        // BOOK EDIT
        public void EditBook(int bookID, String isbn, String title, int pageCount, int authorID, int genreID, int publisherID, DateTime publishDate, int quantity)
        {
            try
            {
                if (!isbn.Trim().Equals(""))
                {
                    dbOpen();
                    cmd = new SqlCommand("UPDATE Books SET ISBN=@isbn, bookTitle=@title, bookPageCount=@pageCount, bookAuthorID=@authorID, bookGenreID=@genreID, bookPublisherID=@publisherID, bookPublishDate=@publishDate, bookQuantity=@quantity WHERE bookID=" + bookID, conn);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@title", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(title.Trim()));
                    cmd.Parameters.AddWithValue("@pageCount", pageCount);
                    cmd.Parameters.AddWithValue("@authorID", authorID);
                    cmd.Parameters.AddWithValue("@genreID", genreID);
                    cmd.Parameters.AddWithValue("@publisherID", publisherID);
                    cmd.Parameters.AddWithValue("@publishDate", Convert.ToDateTime(publishDate.ToShortDateString()));
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.EditMessage();
                }
                else
                    msg.EmptyItem("Book ISBN");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //
        // BOOK DELETE
        public int DeleteBook(int bookID)
        {
            try
            {
                if (msg.ConfirmDeleteMessage() == DialogResult.Yes)
                {
                    dbOpen();
                    cmd = new SqlCommand("DELETE FROM Books WHERE bookID=" + bookID, conn);
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.DeleteMessage();
                    return 1;
                }
                else
                    return 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return 0;
            }
        }

        //
        //BOOK LIST
        public DataTable BookList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT bookID, ISBN, bookTitle, bookPageCount, Authors.authorName, Genres.genreName, " +
                    "Publishers.publisherName, bookPublishDate, bookQuantity, bookAuthorID, bookGenreID, bookPublisherID " +
                    "FROM (((Books INNER JOIN Authors ON Books.bookAuthorID = Authors.authorID) " +
                    "INNER JOIN Genres ON Books.bookGenreID = Genres.genreID) " +
                    "INNER JOIN Publishers ON Books.bookPublisherID = Publishers.publisherID) ORDER BY bookTitle", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        //BOOK LIST FOR EXCEL
        public DataTable BookExcelList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT bookID, ISBN, bookTitle, bookPageCount, Authors.authorName, Genres.genreName, Publishers.publisherName, bookPublishDate, bookQuantity FROM (((Books INNER JOIN Authors ON Books.bookAuthorID = Authors.authorID) INNER JOIN Genres ON Books.bookGenreID = Genres.genreID) INNER JOIN Publishers ON Books.bookPublisherID = Publishers.publisherID) ORDER BY bookID", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        // BOOK DATA UNIQUE CONTROL
        public bool BookDataIsUnique(String isbn)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(ISBN) FROM Books WHERE ISBN='" + isbn + "'", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                if (count != 0)
                    return false;
                else
                    return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        // BOOK DATA COUNT
        public int BookDataCount()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(bookID) FROM Books", conn);
                int dataCount = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                return dataCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //
        // BOOK DATA SEARCH
        public DataTable BookDataSearch(String field, String value)
        {
            String query = "SELECT bookID, ISBN, bookTitle, bookPageCount, Authors.authorName, Genres.genreName, Publishers.publisherName, bookPublishDate, bookQuantity, bookAuthorID, bookGenreID, bookPublisherID FROM (((Books INNER JOIN Authors ON Books.bookAuthorID = Authors.authorID) INNER JOIN Genres ON Books.bookGenreID = Genres.genreID) INNER JOIN Publishers ON Books.bookPublisherID = Publishers.publisherID) WHERE ";

            try
            {
                if (value != "")
                {
                    if (field == "bookTitle")
                    {
                        query += field + " LIKE '" + value + "%'";
                        query += " ORDER BY bookTitle";
                    }                        
                    else if (field == "ISBN")
                        query += field + "='" + value + "'";
                    else if (field == "bookID")
                        query += field + "=" + Convert.ToInt32(value);                    

                    dbOpen();
                    cmd = new SqlCommand(query, conn);
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    dbClose();
                    return dt;
                }
                else
                {
                    if (field == "bookTitle")
                        msg.EmptyItem("Book Title");
                    else
                        msg.EmptyItem("ISBN");
                    return dt;
                }                             
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }
        


        //
        // CIRCULATION DATABASE OPERATIONS
        //
        // BORROW ADD
        public bool AddBorrow(int bookID, int memberID, DateTime borrowDate, DateTime returnDate, String note)
        {
            bool status = true;

            try
            {
                if (bookID > 0)
                {
                    if (BorrowIsUnique(bookID, memberID))
                    {
                        dbOpen();
                        cmd = new SqlCommand("INSERT INTO Circulation(bookID, memberID, status, borrowDate, returnDate, note) VALUES (@BookID, @MemberID, @Status, @BorrowDate, @ReturnDate, @Note)", conn);
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.Parameters.AddWithValue("@MemberID",memberID);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@BorrowDate", Convert.ToDateTime(borrowDate.ToShortDateString()));
                        cmd.Parameters.AddWithValue("@ReturnDate", Convert.ToDateTime(returnDate.ToShortDateString()));
                        cmd.Parameters.AddWithValue("@Note", note);
                        cmd.ExecuteNonQuery();
                        dbClose();
                        msg.AddMessage();
                        return true;
                    }
                    else
                    {
                        msg.ItemExist();
                        return false;
                    }

                }
                else
                {
                    msg.EmptyItem("T.C.No");
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        // BORROW DATA UNIQUE CONTROL
        public bool BorrowIsUnique(int bookID, int memberID)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(ID) FROM Circulation WHERE bookID=" + bookID + " AND memberID=" + memberID, conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                if (count != 0)
                    return false;
                else
                    return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        //BORROW SEARCH
        public DataTable BorrowDataSearch(int index, int status, String searchValue)
        {
            int memberID = 0;
 
            String query = "SELECT ID, Circulation.bookID, Circulation.memberID, status, borrowDate, returnDate, note, Books.bookTitle, [memberName] + ' ' + [memberSurname] AS [name] FROM ((Circulation INNER JOIN Books ON Circulation.bookID = Books.bookID) INNER JOIN Members ON Circulation.memberID = Members.memberID) WHERE ";

            switch (index)
            {
                case 0:
                    query += "ID=" + Convert.ToInt32(searchValue);
                    break;
                case 1:
                    dbOpen();
                    cmd = new SqlCommand("SELECT memberID FROM Members WHERE memberTCNo='" + searchValue + "'", conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    
                    if(dr.Read())
                        memberID = dr.GetInt32(0);

                    dbClose();

                    query += "Circulation.memberID=" + memberID;                    
                    break;
             }            
            switch(status)
            {
                case 0:
                    break;
                case 1:
                    query += " AND status=1";
                    break;
                case 2:
                    query += " AND status=0";
                    break;
            }            
             try
             {
                dbOpen();
                cmd = new SqlCommand(query, conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                    msg.NotFindItem();
                dbClose();
                return dt;
            }
             catch (Exception err)
             {
                MessageBox.Show(err.ToString());
                return dt;
             }
        }

        //
        // BORROW EDIT
        public void EditBorrow(int ID, DateTime returnDate, String note)
        {
            bool status = false;

            try
            {
                if (ID != 0)
                {
                    dbOpen();
                    cmd = new SqlCommand("UPDATE Circulation SET status=@Status, returnDate=@ReturnDate, note=@Note WHERE ID=" + ID, conn);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ReturnDate", returnDate.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Note", note);                    
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.EditMessage();
                }
                else
                    msg.EmptyItem("Borrow ID");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //
        // RETURN - BORROWED
        public void ReturnBorrowed(int ID, DateTime returnDate, String note)
        {
            bool status = false;

            try
            {
                if (ID != 0)
                {
                    dbOpen();
                    cmd = new SqlCommand("UPDATE Circulation SET status=@Status, returnDate=@ReturnDate, note=@Note WHERE ID=" + ID, conn);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ReturnDate", Convert.ToDateTime(returnDate.ToShortDateString()));
                    cmd.Parameters.AddWithValue("@Note", note);
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.EditMessage();
                }
                else
                    msg.EmptyItem("Borrow ID");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }



        //
        // USERS DATABASE OPERATIONS
        //
        // USER ADD
        public bool AddUser(String username, String password, String name, String surname, String gender, 
            DateTime birthDate, String phone, String email)
        {
            try
            {
                if (username.Trim().Equals(""))
                {
                    if (UserDataIsUnique(username))
                    {
                        dbOpen();
                        cmd = new SqlCommand("INSERT INTO Users(username, password, name, surname, gender, birthDate, phone, email) VALUES (@Username, @Password, @Name, @Surname,@Gender, @BirthDate, @Phone, @EMail)", conn);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Name", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.Trim()));
                        cmd.Parameters.AddWithValue("@Surname", surname.Trim().ToUpper());
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@BirthDate", Convert.ToDateTime(birthDate.ToShortDateString()));
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@EMail", email.Trim());
                        cmd.ExecuteNonQuery();
                        dbClose();
                        msg.AddMessage();
                        return true;
                    }
                    else
                    {
                        msg.ItemExist();
                        return false;
                    }
                }
                else
                {
                    msg.EmptyItem("Username");
                    return false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        // USER EDIT
        public void EditUser(int id, String username, String password, String name, String surname, String gender, 
            DateTime birthDate, String phone, String email)
        {
            try
            {
                if (!username.Trim().Equals(""))
                {
                    dbOpen();
                    cmd = new SqlCommand("UPDATE Users SET username=@Username, name=@Name, surname=@Surname, gender=@Gender, birthDate=@BirthDate, phone=@Phone, email=@EMail WHERE id=" + id, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Name", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.Trim()));
                    cmd.Parameters.AddWithValue("@Surname", surname.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@BirthDate", Convert.ToDateTime(birthDate.ToShortDateString()));
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@EMail", email.Trim());
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.EditMessage();
                }
                else
                    msg.EmptyItem("Username");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //
        // USER DELETE
        public int DeleteUser(int id)
        {
            try
            {
                if (msg.ConfirmDeleteMessage() == DialogResult.Yes)
                {
                    dbOpen();
                    cmd = new SqlCommand("DELETE FROM Users WHERE id=" + id, conn);
                    cmd.ExecuteNonQuery();
                    dbClose();
                    msg.DeleteMessage();
                    return 1;
                }
                else
                    return 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return 0;
            }
        }

        //
        //USER LIST
        public DataTable UserList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT id, username, password, [name] + ' ' + [surname] AS [NameSurname], " +
                    "gender, birthDate, phone, email, name, surname  FROM Users ORDER BY id", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        // USER DATA UNIQUE CONTROL
        public bool UserDataIsUnique(String username)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(id) FROM Users WHERE username='" + username + "'", conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                if (count != 0)
                    return false;
                else
                    return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
        }

        //
        // USER DATA COUNT
        public int UserDataCount()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT COUNT(id) FROM Users", conn);
                int dataCount = Convert.ToInt32(cmd.ExecuteScalar());
                dbClose();
                return dataCount;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //
        // USER DATA SEARCH T.C.No
        public DataTable UserDataSearch(String value)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT id, username, name, surname, gender, birthDate, phone, email, [name] + ' ' + [surname] AS [NameSurname] FROM Users WHERE username='" + value, conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        // USER DATA SEARCH ID
        public DataTable UserDataSearch(int value)
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT id, username, name, surname, gender, birthDate, phone, email, [name] + ' ' + [surname] AS [NameSurname] FROM Users WHERE id=" + value, conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        //BOOK LIST FOR EXCEL
        public DataTable UserExcelList()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT id, username, [name] + ' ' + [surname] AS [NameSurname], gender, birthDate, phone, email FROM Users ORDER BY id", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }




        //
        // FIND MOST BORROWED MEMBERS
        public DataTable MembersBorrowed()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT TOP 5 CONCAT(Members.memberName, ' ', Members.memberSurname) AS NameSurname, COUNT(Circulation.memberID) AS NumberOfMember FROM Circulation LEFT JOIN Members ON Members.memberID=Circulation.memberID GROUP BY Members.memberName, Members.memberSurname, Circulation.memberID ORDER BY COUNT(Circulation.memberID) DESC", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }

        //
        // FIND MOST BORROWED BOOKS
        public DataTable BooksBorrowed()
        {
            try
            {
                dbOpen();
                cmd = new SqlCommand("SELECT TOP 5 Books.bookTitle, COUNT(Circulation.bookID) AS NumberOfBook FROM Circulation LEFT JOIN Books ON Books.bookID=Circulation.bookID GROUP BY Books.bookTitle, Circulation.bookID ORDER BY COUNT(Circulation.bookID) DESC", conn);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dbClose();
                return dt;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return dt;
            }
        }


    }
}
