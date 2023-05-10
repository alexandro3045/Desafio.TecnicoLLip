import { Component } from "react";
import GridPopup from "./gridpopup";

type Props = {};

type Projects = { id: number, titulo: string, descricao: string, dataCriacao: Date };

type State = { data: Array<Projects>, redirect: string | null };

export default class Popup extends Component<Props, State> {
  constructor(props: Props) {

    super(props);

      this.state = { data: [], redirect: null };

  }

  render() {
    return (
      <GridPopup/>          
    );
  }
}