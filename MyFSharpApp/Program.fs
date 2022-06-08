open System 
// 이 애플리케이션은 open 키워드를 통해 가져오는 System 클래스 라이브러리를 사용합니다.

let from whom =
    sprintf "from %s" whom
// from 함수는 whom 문자열 매개 변수를 사용하여 문자열 메시지를 만들고 서식을 지정합니다.

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message
    0 // return an integer exit code
    
// main 함수는 애플리케이션의 진입점입니다. 
// from 함수를 사용하여 "from F#" 메시지를 만들고 값을 message에 바인딩합니다.
// 그런 다음 printfn 함수를 사용하여 "F#에서 헬로 월드"를 콘솔에 출력합니다.



// For more information see https://aka.ms/fsharp-console-apps
// printfn "Hello from F#"
