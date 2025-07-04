namespace EdgeFunctionWorld.wit.exports.wasi.http.v0_2_0;
using System.Text;

using EdgeFunctionWorld;
using EdgeFunctionWorld.wit.exports.wasi.http.v0_2_0;
using EdgeFunctionWorld.wit.imports.wasi.http.v0_2_0;
using EdgeFunctionWorld.wit.imports.wasi.io.v0_2_0;

public class IncomingHandlerImpl: IIncomingHandler {
    public static void Handle(ITypes.IncomingRequest request, ITypes.ResponseOutparam responseOut) {
        byte[] content = "Hello, World!"u8.ToArray();
        List<(string, byte[])> headers =
        [
            ("content-type", "text/plain"u8.ToArray()),
            ("content-length", Encoding.ASCII.GetBytes(content.Length.ToString()))
        ];

        ITypes.OutgoingResponse response = new(ITypes.Fields.FromList(headers));
        ITypes.OutgoingBody body = response.Body();

        ITypes.ResponseOutparam.Set(responseOut, Result<ITypes.OutgoingResponse, ITypes.ErrorCode>.Ok(response));

        using IStreams.OutputStream stream = body.Write();
        stream.BlockingWriteAndFlush(content);
        stream.Dispose();

        ITypes.OutgoingBody.Finish(body, null);
    }
}

