using Grpc.Core;

namespace gRPC.Server.Services;

public class CalculatorService : Calculator.CalculatorBase
{
    public CalculatorService() { }

    public override Task<CalculatorReply> Add(CalculatorRequest request, ServerCallContext context)
    {
        return !double.TryParse(request.X, out double x) || !double.TryParse(request.Y, out double y)
            ? throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid input"))
            : Task.FromResult(new CalculatorReply { Result = (x + y).ToString() });

    }

    public override Task<CalculatorReply> Subtract(CalculatorRequest request, ServerCallContext context)
    {
        return !double.TryParse(request.X, out double x) || !double.TryParse(request.Y, out double y)
            ? throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid input"))
            : Task.FromResult(new CalculatorReply { Result = (x - y).ToString() });
    }

    public override Task<CalculatorReply> Multiply(CalculatorRequest request, ServerCallContext context)
    {
        return !double.TryParse(request.X, out double x) || !double.TryParse(request.Y, out double y)
            ? throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid input"))
            : Task.FromResult(new CalculatorReply { Result = (x * y).ToString() });
    }

    public override Task<CalculatorReply> Divide(CalculatorRequest request, ServerCallContext context)
    {
        return !double.TryParse(request.X, out double x) || !double.TryParse(request.Y, out double y)
            ? throw new RpcException(new Status(StatusCode.InvalidArgument, "Invalid input"))
            : Task.FromResult(new CalculatorReply { Result = (x / y).ToString() });
    }
}