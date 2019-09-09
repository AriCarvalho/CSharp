namespace PadroesDeProjeto.EventAggregator
{
     interface IReceiver<T>
    {
        void OnEvent(T e);
    }
}