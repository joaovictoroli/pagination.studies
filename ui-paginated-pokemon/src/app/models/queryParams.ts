export class QueryParams {
  PageNumber?: number;
  ItemsInPage?: number;
  nameFilter?: string = '';
  typeFilter: string = '';

  // constructor(
  //   PageNumber: number,
  //   ItemsInPage: number,
  //   nameFilter: string | undefined,
  //   typeFilter: string | undefined
  // ) {
  //   this.PageNumber = PageNumber;
  //   this.ItemsInPage = ItemsInPage;
  //   this.nameFilter = nameFilter;
  //   this.typeFilter = typeFilter;
  // }
}
