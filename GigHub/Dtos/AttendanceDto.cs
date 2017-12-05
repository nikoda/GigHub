namespace GigHub.Dtos
{
    // Dto = Data Transfer Object
    // Architectural pattern to send data across processes
    // So here we have a piece of code running on the client
    // And another piece running on the server.
    // When we communicate between these two processes we use a Dto Data Transfer Object
    public class AttendanceDto
    {
        public int GigId { get; set; }
    }
}