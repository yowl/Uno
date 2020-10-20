declare class TSBindingsTests {
    TSBindingsTests(): void;
    When_IntPtr(pParams: number, pReturn: number): boolean;
    When_IntPtr_Zero(pParams: number, pReturn: number): boolean;
    When_SingleString(pParams: number, pReturn: number): boolean;
    When_SingleUnicodeString(pParams: number, pReturn: number): boolean;
    When_NullString(pParams: number, pReturn: number): boolean;
    When_ArrayOfInt(pParams: number, pReturn: number): boolean;
    When_NullArrayOfInt(pParams: number, pReturn: number): boolean;
    When_ArrayOfStrings(pParams: number, pReturn: number): boolean;
    When_ArrayOfUnicodeStrings(pParams: number, pReturn: number): boolean;
    When_NullArrayOfStrings(pParams: number, pReturn: number): boolean;
    When_ArrayOfNullStrings(pParams: number, pReturn: number): boolean;
}
declare class GenericReturn {
    Value: string;
    marshal(pData: number): void;
}
declare class When_ArrayOfIntParams {
    MyArray_Length: number;
    MyArray: Array<number>;
    static unmarshal(pData: number): When_ArrayOfIntParams;
}
declare class When_ArrayOfStringParams {
    MyArray_Length: number;
    MyArray: Array<string>;
    static unmarshal(pData: number): When_ArrayOfStringParams;
}
declare class When_ArrayOfStringsParams {
    MyArray_Length: number;
    MyArray: Array<string>;
    static unmarshal(pData: number): When_ArrayOfStringsParams;
}
declare class When_IntPtrParams {
    Id: number;
    static unmarshal(pData: number): When_IntPtrParams;
}
declare class When_SingleStringParams {
    MyString: string;
    static unmarshal(pData: number): When_SingleStringParams;
}
