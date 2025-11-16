/// <author>Bruno Paiva (a31496@alunos.ipca.pt)</author>
/// <version>0.1</version>
/// <date>2025-11-15</date>
/// <copyright>Copyright (c) 2025</copyright>

using System;
using System.Collections.Generic;

namespace Projeto_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Gestão de Obras de Construção ===\n");

            try
            {
                // 1. Criar uma obra
                ConstructionWork obra = new ConstructionWork(
                    "Casa Moderna",
                    "Rua Principal, 123 - Lisboa",
                    50000m
                );
                Console.WriteLine($"✓ Obra criada: {obra.GetName()}");
                Console.WriteLine($"  Endereço: {obra.GetAddress()}");
                Console.WriteLine($"  Orçamento: €{obra.GetEstimatedCost():F2}\n");

                // 2. Criar materiais
                Material concreto = new Material(1, "Concreto", 150m);
                Material aco = new Material(2, "Aço Reforçado", 250m);
                Material madeira = new Material(3, "Madeira", 50m);
                Console.WriteLine("✓ Materiais criados:");
                Console.WriteLine($"  - {concreto.GetDescription()} (€{concreto.GetPrice()})");
                Console.WriteLine($"  - {aco.GetDescription()} (€{aco.GetPrice()})");
                Console.WriteLine($"  - {madeira.GetDescription()} (€{madeira.GetPrice()})\n");

                // 3. Criar armazém (storage)
                Storage armazem1 = new Storage("Armazém Principal", new List<StorageItem>());
                obra.addStorage(armazem1);
                Console.WriteLine("✓ Armazém criado e adicionado à obra\n");

                // 4. Adicionar materiais ao armazém
                Console.WriteLine("Adicionando materiais ao armazém:");
                obra.addMaterialToStorage("Armazém Principal", concreto, 100);
                Console.WriteLine($"  ✓ 100 unidades de concreto");
                
                obra.addMaterialToStorage("Armazém Principal", aco, 50);
                Console.WriteLine($"  ✓ 50 unidades de aço");
                
                obra.addMaterialToStorage("Armazém Principal", madeira, 200);
                Console.WriteLine($"  ✓ 200 unidades de madeira\n");

                // 5. Consultar quantidade de material em stock
                Console.WriteLine("Stock atual:");
                Console.WriteLine($"  Concreto: {obra.getStockQuantity(1)} unidades");
                Console.WriteLine($"  Aço: {obra.getStockQuantity(2)} unidades");
                Console.WriteLine($"  Madeira: {obra.getStockQuantity(3)} unidades\n");

                // 6. Remover material do armazém
                Console.WriteLine("Removendo 20 unidades de concreto...");
                obra.removeMaterialFromStorage("Armazém Principal", 1, 20);
                Console.WriteLine($"  ✓ Concreto restante: {obra.getStockQuantity(1)} unidades\n");

                // 7. Criar serviços
                Service servico1 = new Service("Demolição", 5000m);
                Service servico2 = new Service("Fundações", 8000m);
                obra.addService(servico1);
                obra.addService(servico2);
                Console.WriteLine("✓ Serviços criados e adicionados:");
                Console.WriteLine($"  - {servico1.GetDescription()}: €{servico1.GetCost():F2}");
                Console.WriteLine($"  - {servico2.GetDescription()}: €{servico2.GetCost():F2}\n");

                // 8. Criar mão de obra (labor)
                Labor labor1 = new Labor("Pedreiro", 2500m, false);
                Labor labor2 = new Labor("Encanador (Subcontratado)", 3000m, true);
                obra.addLabor(labor1);
                obra.addLabor(labor2);
                Console.WriteLine("✓ Mão de obra criada:");
                Console.WriteLine($"  - {labor1.GetDescription()}: €{labor1.GetCost():F2} (Contratado)");
                Console.WriteLine($"  - {labor2.GetDescription()}: €{labor2.GetCost():F2} (Subcontratado)\n");

                // 9. Criar e registar veículos
                Vehicle viatura1 = new Vehicle("Betoneira", "AA-12-BC", 50m);
                Vehicle viatura2 = new Vehicle("Grua", "BB-34-DE", 150m);
                obra.registerVehicle(viatura1);
                obra.registerVehicle(viatura2);
                Console.WriteLine("✓ Veículos registados:");
                Console.WriteLine($"  - {viatura1.GetModel()} ({viatura1.GetPlate()}): €{viatura1.GetCostPerHour()}/hora");
                Console.WriteLine($"  - {viatura2.GetModel()} ({viatura2.GetPlate()}): €{viatura2.GetCostPerHour()}/hora\n");

                // 10. Registar uso de veículos
                Console.WriteLine("Adicionando uso de veículos:");
                obra.addVehicleUsage("AA-12-BC", 50m, 8.5m);  // 8.5 horas = 9 horas (arredondado)
                Console.WriteLine($"  ✓ Betoneira: 8.5 horas");
                
                obra.addVehicleUsage("BB-34-DE", 150m, 12.2m);  // 12.2 horas = 13 horas (arredondado)
                Console.WriteLine($"  ✓ Grua: 12.2 horas\n");

                // 11. Criar orçamento
                Budget orcamento = new Budget("Orçamento Inicial", 50000m, DateTime.Now);
                obra.addBudget(orcamento);
                Console.WriteLine($"✓ Orçamento criado: €{orcamento.GetBudgetValue():F2}\n");

                // 12. Criar documento
                Document documento = new Document("Planta", "/docs/planta_obra.pdf", DateTime.Now);
                obra.AddDocument(documento);
                Console.WriteLine($"✓ Documento adicionado: {documento.GetDocumentType()}\n");

                // 13. Calcular custos totais
                Console.WriteLine("=== RESUMO DE CUSTOS ===");
                decimal custMateriais = obra.totalCostMaterials();
                decimal custServicos = obra.totalCostServices();
                decimal custLabor = obra.totalCostLabor();
                decimal custViaturas = obra.totalCostVehicles();
                decimal custTotal = obra.totalCost();

                Console.WriteLine($"Custo de Materiais: €{custMateriais:F2}");
                Console.WriteLine($"Custo de Serviços: €{custServicos:F2}");
                Console.WriteLine($"Custo de Mão de Obra: €{custLabor:F2}");
                Console.WriteLine($"Custo de Veículos: €{custViaturas:F2}");
                Console.WriteLine($"─────────────────────────");
                Console.WriteLine($"CUSTO TOTAL: €{custTotal:F2}\n");

                // 14. Variação de orçamento
                decimal variacao = obra.budgetVariation();
                Console.WriteLine($"Orçamento Estimado: €{obra.GetEstimatedCost():F2}");
                Console.WriteLine($"Custo Real: €{custTotal:F2}");
                if (variacao >= 0)
                    Console.WriteLine($"Poupança: €{variacao:F2} ✓");
                else
                    Console.WriteLine($"Excesso: €{Math.Abs(variacao):F2} ✗\n");

                Console.WriteLine("=== FIM DO PROGRAMA ===");
            }
            catch (InvalidQuantityException ex)
            {
                Console.WriteLine($"❌ Erro de Quantidade: {ex.Message}");
            }
            catch (MaterialNotFoundException ex)
            {
                Console.WriteLine($"❌ Material não encontrado: {ex.Message}");
            }
            catch (InsufficientStockException ex)
            {
                Console.WriteLine($"❌ Stock insuficiente: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Erro inesperado: {ex.Message}");
            }
        }
    }
}