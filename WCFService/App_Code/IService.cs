using System.Runtime.Serialization;
using System.ServiceModel;

// NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService" nel codice e nel file di configurazione contemporaneamente.
[ServiceContract(Namespace = "http://wcfsoap/services")]
public interface IService
{

	// Ensures consistency in the namespace declarations across services
	[OperationContract]
	string GetData(int value);

	[OperationContract]
	CompositeType GetDataUsingDataContract(CompositeType composite);

	// TODO: aggiungere qui le operazioni del servizio
}

// Per aggiungere tipi compositi alle operazioni del servizio utilizzare un contratto di dati come descritto nell'esempio seguente.
[DataContract]
public class CompositeType
{
	[DataMember]
	public bool BoolValue { get; set; }

	[DataMember]
	public string StringValue { get; set; } = "Hello ";
}
