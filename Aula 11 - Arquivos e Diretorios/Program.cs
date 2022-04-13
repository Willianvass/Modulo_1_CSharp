using System;

namespace Arquivos_Diretorios
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            var folderName = "pasta";
            var subFolderName = "subpasta";
            var subFolderNameStatic = "subpasta_usingstatic";//Para diferenciar da Directory e DirectoryInfo

            //Criando objeto instanciando a subpasta
            var directoryInfoSubFolder = new DirectoryInfo(subFolderName);
            //Verificando se existe a pasta
            if (!Directory.Exists(subFolderName) || directoryInfoSubFolder.Exists)
            {
                //Criando a pasta 2 maneiras, create se tiver instanciado > Estão na pasta BIN quando criadas
                Directory.CreateDirectory(subFolderNameStatic);
                Directory.CreateDirectory(folderName);
                directoryInfoSubFolder.Create();
                //Movendo de uma para outra pasta > Colocando a Subpasta para dentro da pasta
                directoryInfoSubFolder.MoveTo($"{folderName}//{subFolderName}");
                //Outra maneira para mostrar o caminho das pastas usando o @ e \\ 
                Directory.Move(subFolderNameStatic, @$"{folderName}\\{subFolderNameStatic}");
            }

            var name = directoryInfoSubFolder.Name;
            var parent = directoryInfoSubFolder.Parent;
            var root = directoryInfoSubFolder.Root;
            var exist = directoryInfoSubFolder.Exists;

            //Como percorrer dentro das pastas
            foreach (var directory in Directory.GetDirectories(folderName))
            {
                System.Console.WriteLine(directory);
            }
            //Deletando a subFolderName
            Directory.Delete($@"{folderName}\\{subFolderName}");

            //Criando a variavel e passando o caminho
            var file = @"pasta\texto.txt";
            //Verificando se o arquivo existe
            if (!File.Exists(file))
            {
                File.CreateText(file);
            }
            //Incializando o FileInfo passando o caminho
            var fileInfo = new FileInfo(file);

            System.Console.WriteLine($"Nome: {fileInfo.Name}, Tamanho: {fileInfo.Length}, Data de Atualização: {fileInfo.LastWriteTime}");


            Console.ReadKey();

        }
    }
}