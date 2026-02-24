using TransCRM_ERP.Entites.BaseData;
using TransCRM_ERP.Entites.Enums;

namespace TransCRM_ERP.DTO
{
    public record RequiredReadBaseDto(
        Guid Id,
        string RequestNumb,
        DateOnly RequestDate,
        string? RequestNumbAdd,
        double RequestCostStart,
        TypeTransportation TypeTransportation,
        List<DrivingRoute> DrivingRoutes,
        RequestStatus RequestStatus,
        string? Comment
        );

    public record RequiredReadFullDto(
        Guid Id,
        string RequestNumb,
        DateOnly RequestDate,
        string? RequestNumbAdd,
        double RequestCostStart,
        TypeTransportation TypeTransportation,
        List<DrivingRoute> DrivingRoutes,
        RequestStatus RequestStatus,
        List<Waybill>? Waybills,
        Guid? AutotransportId,
        Autotransport? Autotransport,
        Guid? DriverId,
        Driver? Driver,
        double RequestCostFinal,
        string? Comment
        );

    public record RequiredCreateDto(
        string RequestNumb,
        DateOnly RequestDate,
        string? RequestNumbAdd,
        double RequestCostStart,
        TypeTransportation TypeTransportation,
        List<DrivingRoute> DrivingRoutes,
        RequestStatus RequestStatus,
        List<Waybill>? Waybills,
        Guid? AutotransportId,
        Autotransport? Autotransport,
        Guid? DriverId,
        Driver? Driver,
        double RequestCostFinal,
        string? Comment
        );
}