using Grpc.Core;

namespace gRPC.Server.Services;

public class CalculatorService : Calculator.CalculatorBase
{
    public CalculatorService() { }

    public override Task<CalculatorReply> Add(CalculatorRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CalculatorReply { Result = request.X + request.Y });
    }

    public override Task<CalculatorReply> Subtract(CalculatorRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CalculatorReply { Result = request.X - request.Y });
    }

    public override Task<CalculatorReply> Multiply(CalculatorRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CalculatorReply { Result = request.X * request.Y });
    }

    public override Task<CalculatorReply> Divide(CalculatorRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CalculatorReply { Result = request.X / request.Y }); ;
    }
}