
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Scanner;

public class Filewriter {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		while(true) {
			Startmenu(scan);
		}
	}
	
	public static void clearScreen() {  
		for (int i = 0; i < 50; ++i) System.out.println();
	} 
	public static void getfiles() {
		File folder = new File("C:/Users/frni/Desktop/Files");
		File[] listOfFiles = folder.listFiles();

		    for (int i = 0; i < listOfFiles.length; i++) {
		      if (listOfFiles[i].isFile()) {
		        System.out.println("File " + listOfFiles[i].getName());
		      } else if (listOfFiles[i].isDirectory()) {
		        System.out.println("Directory " + listOfFiles[i].getName());
		      }
		    }
		    System.out.println("-------------------------------");
		    System.out.println("-------------------------------");
		    System.out.println("-------------------------------");
	}
	
	public static void Startmenu(Scanner scan) {
		System.out.println("Select what you want to do:");
		System.out.println("1 - List files");
		System.out.println("2 - delete file");
		System.out.println("3 - create file");
		System.out.println("4 - insert into file");
		String scanned = scan.nextLine();
		switch (scanned) {
		case "1":
			clearScreen();
			getfiles();
			break;
		case "2":
			clearScreen();
			deletefile(scan);
			break;
		case "3":
			clearScreen();
			createfile(scan);
			break;
		case "4":
				Insert(scan);
			break;
		default:
			clearScreen();
			Startmenu(scan);
			break;
		}
	}

	private static void Insert(Scanner path)  {
		// TODO Auto-generated method stub
		System.out.println("Type the name of the file you want to insert into (without .txt)");
		String file = path.nextLine();
		
		System.out.println("Type what you want to insert:");
		String str = path.nextLine();
		FileWriter fileWriter;
		try {
			fileWriter = new FileWriter("C:/Users/frni/Desktop/Files/" + file + ".txt");
			PrintWriter printWriter = new PrintWriter(fileWriter);
		    printWriter.print(str);
		    printWriter.close();
		} catch (IOException e) {
		}
		
		
	}

	private static void createfile(Scanner path) {
		// TODO Auto-generated method stub
		 try {
			 System.out.println("Type the name of the file you want to create (without .txt)");
		     File file = new File("C:/Users/frni/Desktop/Files/" + path.nextLine() + ".txt");
	             boolean fvar = file.createNewFile();
	             file = null;
		     if (fvar){
		          System.out.println("File has been created successfully");
		     }
		     else{
		          System.out.println("File already present at the specified location");
		     }
	    	} catch (IOException e) {
	    		System.out.println("Exception Occurred:");
		        e.printStackTrace();
		  }

	}

	private static void deletefile(Scanner path) {
		// TODO Auto-generated method stub
		System.out.println("Type the name of the file you want to delete (without .txt)");
		File filePath = new File("C:/Users/frni/Desktop/Files/" + path.nextLine() + ".txt");
		filePath.delete();
		filePath = null;
		
	}

}
