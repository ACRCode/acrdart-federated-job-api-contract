namespace Acr.Dart.FederatedNetwork.Api.Contract.Enums
{
    public enum FederatedJobStatus
    {
        Submitted = 1,
        Initiated = 2,
        PreparingDataset = 3,
        InProgress = 4,
        Completed = 5,
        Failed = 6,
        NoDataFound = 7,
        CancelRequested = 8,
        Canceled = 9
    }
}
