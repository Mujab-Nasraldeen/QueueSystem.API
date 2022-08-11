namespace QueueSystem.API.Helper
{
    public class Common
    {
        public static string GenerateTicketReferenceId()
        {
            string id = Guid.NewGuid().ToString("N");
            DateTime dt = DateTime.Now;
            string dd = dt.Day.ToString();
            string yy = dt.Year.ToString();
            string ticketReferenceId = "TCK-" + dd + yy + "-" + id[..6];
            return ticketReferenceId;
        }
    }
}
