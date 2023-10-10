using semana5_3.Models;
using System;
using System.Collections.Generic;

class Program
{
    static List<Order> orders = new List<Order>();
    static List<Client> clients = new List<Client>();

    static void Main()
    {
        // Inicializar algunos datos de prueba
        clients.Add(new Client("Cliente1", 1000));
        clients.Add(new Client("Cliente2", 1500));

        // Intentar crear una orden (puedes llamar a este método cuando sea necesario)
        CreateOrder("Cliente1", 500, DateTime.Now);
    }

    static void CreateOrder(string clientName, double orderValue, DateTime date)
    {
        // Verificar si ya hay más de 10 órdenes para la fecha dada
        if (CountDateOrders(date) >= 10)
        {
            Console.WriteLine("No se puede registrar la orden. Se superó el límite de 10 órdenes para esta fecha.");
            return;
        }

        // Buscar al cliente por nombre
        Client client = clients.Find(c => c.Name == clientName);

        // Verificar si el cliente existe
        if (client == null)
        {
            Console.WriteLine($"Cliente '{clientName}' no encontrado.");
            return;
        }

        // Verificar si el cliente tiene suficiente crédito
        if (client.AvailableBalance < orderValue)
        {
            Console.WriteLine($"Cliente '{clientName}' no tiene suficiente crédito para realizar el pedido.");
            return;
        }

        // Restar el valor del pedido al crédito del cliente
        client.AvailableBalance -= orderValue;

        // Crear la orden y agregarla a la lista de órdenes
        Order newOrder = new Order(clientName, orderValue, date);
        orders.Add(newOrder);

        Console.WriteLine($"Orden creada para '{clientName}' con un valor de {orderValue}. Nuevo crédito: {client.AvailableBalance}");
    }

    static int CountDateOrders(DateTime dateActual)
    {
        // Contar las órdenes para la fecha dada
        return orders.Count(o => o.Date.Date == dateActual.Date);
    }
}



